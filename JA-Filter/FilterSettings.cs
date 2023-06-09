﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JA_Filter
{
    internal class FilterSettings
    {
        float[] redVal;
        float[] greenVal;
        float[] blueVal;

        public FilterSettings() 
        {
            redVal = new float[3];
            greenVal = new float[3];
            blueVal = new float[3];
        }

        public float[] getRedVal()
        {
            return redVal;
        }
        public float[] getGreenVal()
        {
            return greenVal;
        }
        public float[] getBlueVal()
        {
            return blueVal;
        }

        public void setValues(string type, int strength)
        {
            switch(type)
            {
                case "p":
                    setValuesProtanomaly(strength);
                    break;
                case "d":
                    setValuesDuteranomaly(strength);
                    break;
                case "t":
                    setValuesTritanomaly(strength);
                    break;
            }
        }

        private void setValuesProtanomaly(int strength)
        {
            switch(strength)
            {
                case 1:
                    redVal = new float[] { 0.856167f, 0.182038f, -0.038205f, 0.0f };
                    greenVal = new float[] { 0.029342f, 0.955115f, 0.015544f, 0.0f };
                    blueVal = new float[] { -0.002880f, - 0.001563f, 1.004443f, 0.0f };
                    break;
                case 2:
                    redVal = new float[] { 0.734766f, 0.334872f, -0.069637f, 0.0f };
                    greenVal = new float[] { 0.051840f, 0.919198f, 0.028963f, 0.0f };
                    blueVal = new float[] { -0.004928f, -0.004209f, 1.009137f, 0.0f };
                    break;
                case 3:
                    redVal = new float[] { 0.630323f, 0.465641f, -0.095964f, 0.0f };
                    greenVal = new float[] { 0.069181f, 0.890046f, 0.040773f, 0.0f };
                    blueVal = new float[] { -0.006308f, -0.007724f, 1.014032f, 0.0f };
                    break;
                case 4:
                    redVal = new float[] { 0.539009f, 0.579343f, -0.118352f, 0.0f };
                    greenVal = new float[] { 0.082546f, 0.866121f, 0.051332f, 0.0f };
                    blueVal = new float[] { -0.007136f, -0.011959f, 1.019095f, 0.0f };
                    break;
                case 5:
                    redVal = new float[] { 0.458064f, 0.679578f, -0.137642f, 0.0f };
                    greenVal = new float[] { 0.092785f, 0.846313f, 0.060902f, 0.0f };
                    blueVal = new float[] { -0.007494f, -0.016807f, 1.024301f, 0.0f };
                    break;
                case 6:
                    redVal = new float[] { 0.385450f, 0.769005f, -0.154455f, 0.0f };
                    greenVal = new float[] { 0.100526f, 0.829802f, 0.069673f, 0.0f };
                    blueVal = new float[] { -0.007442f, -0.022190f, 1.029632f, 0.0f };
                    break;
                case 7:
                    redVal = new float[] { 0.319627f, 0.849633f, -0.169261f, 0.0f };
                    greenVal = new float[] { 0.106241f, 0.815969f, 0.077790f, 0.0f };
                    blueVal = new float[] { -0.007025f, -0.028051f, 1.035076f, 0.0f };
                    break;
                case 8:
                    redVal = new float[] { 0.259411f, 0.923008f, -0.182420f, 0.0f };
                    greenVal = new float[] { 0.110296f, 0.804340f, 0.085364f, 0.0f };
                    blueVal = new float[] { -0.006276f, -0.034346f, 1.040622f, 0.0f };
                    break;
                case 9:
                    redVal = new float[] { 0.203876f, 0.990338f, -0.194214f, 0.0f };
                    greenVal = new float[] { 0.112975f, 0.794542f, 0.092483f, 0.0f };
                    blueVal = new float[] { -0.005222f, -0.041043f, 1.046265f, 0.0f };
                    break;
                case 10:
                    redVal = new float[] { 0.152286f, 1.052583f, -0.204868f, 0.0f };
                    greenVal = new float[] { 0.114503f, 0.786281f, 0.099216f, 0.0f };
                    blueVal = new float[] { -0.003882f, -0.048116f, 1.051998f, 0.0f };
                    break;
                default:
                    redVal = new float[] { 0.856167f, 0.182038f, -0.038205f, 0.0f };
                    greenVal = new float[] { 0.029342f, 0.955115f, 0.015544f, 0.0f };
                    blueVal = new float[] { -0.002880f, -0.001563f, 1.004443f, 0.0f };
                    break;
            }
        }

        private void setValuesDuteranomaly(int strength)
        {
            switch (strength)
            {
                case 1:
                    redVal = new float[] { 0.866435f, 0.177704f, -0.044139f, 0.0f };
                    greenVal = new float[] { 0.049567f, 0.939063f, 0.011370f, 0.0f };
                    blueVal = new float[] { -0.003453f, 0.007233f, 0.996220f, 0.0f };
                    break;
                case 2:
                    redVal = new float[] { 0.760729f, 0.319078f, -0.079807f, 0.0f };
                    greenVal = new float[] { 0.090568f, 0.889315f, 0.020117f, 0.0f };
                    blueVal = new float[] { -0.006027f, 0.013325f, 0.992702f, 0.0f };
                    break;
                case 3:
                    redVal = new float[] { 0.675425f, 0.433850f, -0.109275f, 0.0f };
                    greenVal = new float[] { 0.125303f, 0.847755f, 0.026942f, 0.0f };
                    blueVal = new float[] { -0.007950f, 0.018572f, 0.989378f, 0.0f };
                    break;
                case 4:
                    redVal = new float[] { 0.605511f, 0.528560f, -0.134071f, 0.0f };
                    greenVal = new float[] { 0.155318f, 0.812366f, 0.032316f, 0.0f };
                    blueVal = new float[] { -0.009376f, 0.023176f, 0.986200f, 0.0f };
                    break;
                case 5:
                    redVal = new float[] { 0.547494f, 0.607765f, -0.155259f, 0.0f };
                    greenVal = new float[] { 0.181692f, 0.781742f, 0.036566f, 0.0f };
                    blueVal = new float[] { -0.010410f, 0.027275f, 0.983136f, 0.0f };
                    break;
                case 6:
                    redVal = new float[] { 0.498864f, 0.674741f, -0.173604f, 0.0f };
                    greenVal = new float[] { 0.205199f, 0.754872f, 0.039929f, 0.0f };
                    blueVal = new float[] { -0.011131f, 0.030969f, 0.980162f, 0.0f };
                    break;
                case 7:
                    redVal = new float[] { 0.457771f, 0.731899f, -0.189670f, 0.0f };
                    greenVal = new float[] { 0.226409f, 0.731012f, 0.042579f, 0.0f };
                    blueVal = new float[] { -0.011595f, 0.034333f, 0.977261f, 0.0f };
                    break;
                case 8:
                    redVal = new float[] { 0.422823f, 0.781057f, -0.203881f, 0.0f };
                    greenVal = new float[] { 0.245752f, 0.709602f, 0.044646f, 0.0f };
                    blueVal = new float[] { -0.011843f, 0.037423f, 0.974421f, 0.0f };
                    break;
                case 9:
                    redVal = new float[] { 0.392952f, 0.823610f, -0.216562f, 0.0f };
                    greenVal = new float[] { 0.263559f, 0.690210f, 0.046232f, 0.0f };
                    blueVal = new float[] { -0.011910f, 0.040281f, 0.971630f, 0.0f };
                    break;
                case 10:
                    redVal = new float[] { 0.367322f, 0.860646f, -0.227968f, 0.0f };
                    greenVal = new float[] { 0.280085f, 0.672501f, 0.047413f, 0.0f };
                    blueVal = new float[] { -0.011820f, 0.042940f, 0.968881f, 0.0f };
                    break;
                default:
                    redVal = new float[] { 0.866435f, 0.177704f, -0.044139f, 0.0f };
                    greenVal = new float[] { 0.049567f, 0.939063f, 0.011370f, 0.0f };
                    blueVal = new float[] { -0.003453f, 0.007233f, 0.996220f, 0.0f };
                    break;
            }
        }

        private void setValuesTritanomaly(int strength)
        {
            switch (strength)
            {
                case 1:
                    redVal = new float[] { 0.926670f, 0.092514f, -0.019184f, 0.0f };
                    greenVal = new float[] { 0.021191f, 0.964503f, 0.014306f, 0.0f };
                    blueVal = new float[] { 0.008437f, 0.054813f, 0.936750f, 0.0f };
                    break;
                case 2:
                    redVal = new float[] { 0.895720f, 0.133330f, -0.029050f, 0.0f };
                    greenVal = new float[] { 0.029997f, 0.945400f, 0.024603f, 0.0f };
                    blueVal = new float[] { 0.013027f, 0.104707f, 0.882266f, 0.0f };
                    break;
                case 3:
                    redVal = new float[] { 0.905871f, 0.127791f, -0.033662f, 0.0f };
                    greenVal = new float[] { 0.026856f, 0.941251f, 0.031893f, 0.0f };
                    blueVal = new float[] { 0.013410f, 0.148296f, 0.838294f, 0.0f };
                    break;
                case 4:
                    redVal = new float[] { 0.948035f, 0.089490f, -0.037526f, 0.0f };
                    greenVal = new float[] { 0.014364f, 0.946792f, 0.038844f, 0.0f };
                    blueVal = new float[] { 0.010853f, 0.193991f, 0.795156f, 0.0f };
                    break;
                case 5:
                    redVal = new float[] { 1.017277f, 0.027029f, -0.044306f, 0.0f };
                    greenVal = new float[] { -0.006113f, 0.958479f, 0.047634f, 0.0f };
                    blueVal = new float[] { 0.006379f, 0.248708f, 0.744913f, 0.0f };
                    break;
                case 6:
                    redVal = new float[] { 1.104996f, -0.046633f, -0.058363f, 0.0f };
                    greenVal = new float[] { -0.032137f, 0.971635f, 0.060503f, 0.0f };
                    blueVal = new float[] { 0.001336f, 0.317922f, 0.680742f, 0.0f };
                    break;
                case 7:
                    redVal = new float[] { 1.193214f, -0.109812f, -0.083402f, 0.0f };
                    greenVal = new float[] { -0.058496f, 0.979410f, 0.079086f, 0.0f };
                    blueVal = new float[] { -0.002346f, 0.403492f, 0.598854f, 0.0f };
                    break;
                case 8:
                    redVal = new float[] { 1.257728f, -0.139648f, -0.118081f, 0.0f };
                    greenVal = new float[] { -0.078003f, 0.975409f, 0.102594f, 0.0f };
                    blueVal = new float[] { -0.003316f, 0.501214f, 0.502102f, 0.0f };
                    break;
                case 9:
                    redVal = new float[] { 1.278864f, -0.125333f, -0.153531f, 0.0f };
                    greenVal = new float[] { -0.084748f, 0.957674f, 0.127074f, 0.0f };
                    blueVal = new float[] { -0.000989f, 0.601151f, 0.399838f, 0.0f };
                    break;
                case 10:
                    redVal = new float[] { 1.255528f, -0.076749f, -0.178779f, 0.0f };
                    greenVal = new float[] { -0.078411f, 0.930809f, 0.147602f, 0.0f };
                    blueVal = new float[] { 0.004733f, 0.691367f, 0.303900f, 0.0f };
                    break;
                default:
                    redVal = new float[] { 0.926670f, 0.092514f, -0.019184f, 0.0f };
                    greenVal = new float[] { 0.021191f, 0.964503f, 0.014306f, 0.0f };
                    blueVal = new float[] { 0.008437f, 0.054813f, 0.936750f, 0.0f };
                    break;
            }
        }
    }
}
