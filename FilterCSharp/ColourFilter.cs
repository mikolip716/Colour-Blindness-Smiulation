using System;

namespace FilterCSharp
{
    public class ColourFilter
    {
        public void calculateFilter(float[] redVal, float[] greenVal, float[] blueVal, int startIndex, int endIndex, float[] pixels)
        {
            for (int i = startIndex; i < endIndex; i += 4)
            {
                // making sure index does not go out of bounds
                if (i + 1 >= endIndex || i + 2 >= endIndex)
                {
                    break;
                }
                // making sure values stay in RGB range (0-255)
                float tempR = Math.Min(redVal[2] * pixels[i + 2] + redVal[1] * pixels[i + 1] + redVal[0] * pixels[i], 255.0f);    //red
                float tempG = Math.Min(greenVal[2] * pixels[i + 2] + greenVal[1] * pixels[i + 1] + greenVal[0] * pixels[i], 255.0f);  //green
                float tempB = Math.Min(blueVal[2] * pixels[i + 2] + blueVal[1] * pixels[i + 1] + blueVal[0] * pixels[i], 255.0f);     //blue

                pixels[i + 2] = Math.Max(tempR, 0);
                pixels[i + 1] = Math.Max(tempG, 0);
                pixels[i] = Math.Max(tempB, 0);
                
            }
        }
    }
}