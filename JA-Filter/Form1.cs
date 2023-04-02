using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JA_Filter
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        private Bitmap originalImage;
        private Bitmap filteredImage;
        private FilterSettings filterSettings;
        private string type;
        private int strength;
        private string library;
        private int threadCount;
        private bool isPerfTestOn = false;

        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            filterSettings = new FilterSettings();
            threadSlider.Value = System.Environment.ProcessorCount;
            threadCount = threadSlider.Value;
            labelThread.Text = threadSlider.Value.ToString();
            isPerfTestOn = false;
        }
        private void openImage()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Choose image";
            dialog.Filter = "Allowed formats|*.jpg;*.jpeg;*.png;*.bmp|" +
                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg;|" +
                "PNG (*.png)|*.png|" +
                "BMP (*.bmp)|*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK && dialog.CheckFileExists)
            {
                originalImage = new Bitmap(Image.FromFile(dialog.FileName));
            }
        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        private Bitmap scaleImage(Bitmap bitmap, PictureBox pictureBox)
        {
            float aspectRatio = 1.0f;
            int imageHeight = 0;
            int imageWidth = 0;

            if (bitmap == null)
            {
                return bitmap;
            }
            if (bitmap.Height > pictureBox.Height || bitmap.Width > pictureBox.Width)
            {
                Image.GetThumbnailImageAbort myCallback =
                    new Image.GetThumbnailImageAbort(ThumbnailCallback) ;

                if (bitmap.Height >= bitmap.Width)
                {
                    aspectRatio = (((float)bitmap.Width) / ((float)bitmap.Height));
                    imageHeight = pictureBox.Height;
                    imageWidth = (int)((imageHeight) * (aspectRatio));
                }
                else
                {
                    aspectRatio = (((float)bitmap.Height) / ((float)bitmap.Width));
                    imageWidth = pictureBox.Width;
                    imageHeight = (int)((imageWidth) * (aspectRatio));
                }

                Image myThumbnail = bitmap.GetThumbnailImage(imageWidth, imageHeight, myCallback, IntPtr.Zero);
                return new Bitmap(myThumbnail);
            }
            return bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            library = "c#";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (originalImage == null || library == null || type == null)
            {
                return;
            }
            filterSettings.setValues(type, strength);
            if (!isPerfTestOn)
            {
                FilterManager manager = new FilterManager
                    (filterSettings.getRedVal(), filterSettings.getGreenVal(), filterSettings.getBlueVal(), library, threadCount, originalImage);
                TimeSpan timeSpan;
                Bitmap newBitmap = manager.calculateFilter(out timeSpan);
                filteredImage = newBitmap;
                imageAfter.Image = scaleImage(newBitmap, imageAfter);
                timeLabel.Text = timeSpan.ToString().Remove(0, 3);
            }
            else
            {
                TimeSpan avgTime;
                List<TimeSpan> avgTimes = new List<TimeSpan>();
                string[] results = new string[64];
                for (int i = 1; i <= 64; i++)
                {
                    for (int j = 0; j <= 10; j++)
                    {
                        FilterManager manager = new FilterManager
                            (filterSettings.getRedVal(), filterSettings.getGreenVal(), filterSettings.getBlueVal(), library, i, originalImage);
                        TimeSpan timeSpan;
                        Bitmap newBitmap = manager.calculateFilter(out timeSpan);
                        timeLabel.Text = timeSpan.ToString().Remove(0, 6);
                        avgTimes.Add(timeSpan);
                    }
                    avgTime = avgTimes.Mean();
                    results[i-1] = avgTime.ToString().Remove(0, 6);
                    avgTimes.Clear();
                }
                File.WriteAllLines("results.txt", results);
            }
        }

        private void threadSlider_Scroll(object sender, EventArgs e)
        {
            labelThread.Text = threadSlider.Value.ToString();
            threadCount = threadSlider.Value;
        }

        private void strTrackBar_Scroll(object sender, EventArgs e)
        {
            strLabel.Text = strTrackBar.Value.ToString();
            strength = strTrackBar.Value;
        }

        private void loadImgButton_Click(object sender, EventArgs e)
        {
            openImage();
            imageBefore.Image = scaleImage(originalImage, imageBefore);
        }
        private void ProtanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            type = "p";
        }

        private void DeuterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            type = "d";
        }

        private void TritRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            type = "t";
        }

        private void asmRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            library = "asm";
        }

        private void saveImgButton_Click(object sender, EventArgs e)
        {
            if (filteredImage == null)
            {
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save image";
            dialog.Filter = "PNG (*.png)|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filteredImage.Save(dialog.FileName, ImageFormat.Png);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isPerfTestOn = !isPerfTestOn;
        }
    }
}

public static class TimeSpanAvg
{
    public static TimeSpan Mean(this ICollection<TimeSpan> source)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        long mean = 0L;
        long remainder = 0L;
        int n = source.Count;
        foreach (var item in source)
        {
            long ticks = item.Ticks;
            mean += ticks / n;
            remainder += ticks % n;
            mean += remainder / n;
            remainder %= n;
        }

        return TimeSpan.FromTicks(mean);
    }
}
