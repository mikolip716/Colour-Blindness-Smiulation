using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JA_Filter
{
    public abstract class FilterInterface
    {
        protected float[] _redVal;
        protected float[] _greenVal;
        protected float[] _blueVal;
        protected int _startIndex;
        protected int _endIndex;

        public FilterInterface(float[] redVal, float[] greenVal, float[] blueVal, int startIndex, int endIndex)
        {
            _redVal = redVal;
            _greenVal = greenVal;
            _blueVal = blueVal;
            _startIndex = startIndex;
            _endIndex = endIndex;
        }

        public abstract void calcFilter(float[] allPixels);
    }
}
