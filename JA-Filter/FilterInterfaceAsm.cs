using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JA_Filter
{
    internal class FilterInterfaceAsm : FilterInterface
    {
        public FilterInterfaceAsm(float[] redVal, float[] greenVal, float[] blueVal, int startIndex, int endIndex) :
        base(redVal, greenVal, blueVal, startIndex, endIndex)
        { }

        [DllImport(@"E:\!Studia\JA\Projekt\JA-Filter\x64\Release\FilterAsm.dll")]
        static extern int filter(float[] pixels, float[] redVal, float[] greenVal, float[] blueVal, int startIndex, int endIndex);

        public override void calcFilter(float[] pixels)
        {
            filter(pixels, _redVal, _greenVal, _blueVal, _startIndex, _endIndex);
        }
    }
}
