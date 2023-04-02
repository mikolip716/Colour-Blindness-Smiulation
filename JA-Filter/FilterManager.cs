using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Media.Media3D;

namespace JA_Filter
{
    internal class FilterManager
    {
        private float[] _redVal;
        private float[] _greenVal;
        private float[] _blueVal;
        private string _library;
        private float[] pixels;
        private int _threadCount;
        private List<FilterInterface> _filterInterfaces = new List<FilterInterface>();
        private List<Task> _tasks = new List<Task>();
        private BitmapData bitmapData;

        public FilterManager(float[] redVal, float[] greenVal, float[] blueVal, string library, int threadCount, Bitmap image)
        {
            _redVal = redVal;
            _greenVal = greenVal;
            _blueVal = blueVal;
            _library = library;
            _threadCount = threadCount;
            //bitmap uses BGR instead of RGB making this necessary
            Array.Reverse(_redVal, 0, 3);
            Array.Reverse(_greenVal, 0, 3);
            Array.Reverse(_blueVal, 0, 3);

            bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            
            var length = bitmapData.Stride * bitmapData.Height;
            byte[] bytes = new byte[length];          
            Marshal.Copy(bitmapData.Scan0, bytes, 0, length);

            pixels = new float[bytes.Length];
            
            for (int i = 0; i < bytes.Length; i++)
            {
                pixels[i] = (float)bytes[i];
            }
            
            image.UnlockBits(bitmapData);

            int pieceLength = AdjustPieceLength();

            for (int partNumber = 0; partNumber < _threadCount; partNumber++)
            {
                int tempPartNumber = partNumber;
                int pieceEnd;
                if (partNumber + 1 == _threadCount)
                {
                    pieceEnd = pixels.Length;
                }
                else
                    pieceEnd = pieceLength * (tempPartNumber + 1) - 1;
                if (_library.Equals("c#"))
                {
                    _filterInterfaces.Add(new FilterInterfaceCSharp(_redVal, _greenVal, _blueVal, pieceLength * tempPartNumber, pieceEnd));
                }
                if (_library.Equals("asm"))
                {
                    _filterInterfaces.Add(new FilterInterfaceAsm(_redVal, _greenVal, _blueVal, pieceLength * tempPartNumber, pieceEnd));
                }
                _tasks.Add(new Task(() =>
                    _filterInterfaces[tempPartNumber].calcFilter(pixels)));
            }
        }
        private int AdjustPieceLength()
        {
            int pieceLenght = pixels.Length / _threadCount;
            while (pieceLenght % 4 != 0)    //because each pixel is 4 bytes
                pieceLenght++;
            return pieceLenght;
        }

        public Bitmap calculateFilter(out System.TimeSpan elapsedTime)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Parallel.ForEach(_tasks, (task) => task.Start());
            Task.WaitAll(_tasks.ToArray());

            stopwatch.Stop();
            elapsedTime = stopwatch.Elapsed;
            var byteArray = new byte[pixels.Length];

            for (int i = 0; i < pixels.Length; i++)
            {
                byteArray[i] = (byte)pixels[i];
            }

            Bitmap newBitmap = new Bitmap(bitmapData.Width, bitmapData.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            // Create a BitmapData and lock all pixels to be written 
            BitmapData bmpData = newBitmap.LockBits(
                                new Rectangle(0, 0, newBitmap.Width, newBitmap.Height),
                                ImageLockMode.WriteOnly, newBitmap.PixelFormat);
            // Copy the data from the byte array into BitmapData.Scan0
            Marshal.Copy(byteArray, 0, bmpData.Scan0, byteArray.Length);

            // Unlock the pixels
            newBitmap.UnlockBits(bmpData);
            return newBitmap;
        }
    }
}
