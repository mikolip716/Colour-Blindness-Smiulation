using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilterCSharp;

namespace JA_Filter
{
    internal class FilterInterfaceCSharp : FilterInterface
    {
        public FilterInterfaceCSharp(float[] redVal, float[] greenVal, float[] blueVal, int startIndex, int endIndex) :
            base(redVal, greenVal, blueVal, startIndex, endIndex)
        { }
        public override void calcFilter(float[] pixels)
        {
            var colourFilter = new ColourFilter();
            colourFilter.calculateFilter(_redVal, _greenVal, _blueVal, _startIndex, _endIndex, pixels);
        }
    }
}
