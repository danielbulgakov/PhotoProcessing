using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseModels
{
    internal class Raileth
    {
        static double a = 0;
        static double b = 0.4;

        public static Bitmap Execute(Bitmap sourceImage)
        {
            return AdditiveModel.CalculateBitmap(sourceImage, ComputeRayleigh(sourceImage.Width * sourceImage.Height));
        }

        protected static float[] ComputeRayleigh(int size)
        {
            var rayleigh = new float[256];
            float sum = 0f;

            for (int i = 0; i < 256; i++)
            {
                double step = (float)i * 0.01;
                if (step >= a)
                {
                    rayleigh[i] = (float)((2 / b) * (step - a) * Math.Exp(-Math.Pow(step - a, 2) / b));
                }
                else
                {
                    rayleigh[i] = 0;
                }
                sum += rayleigh[i];
            }

            for (int i = 0; i < 256; i++)
            {
                rayleigh[i] /= sum;
                rayleigh[i] *= size;
                rayleigh[i] = (int)Math.Floor(rayleigh[i]);
            }

            return rayleigh;
        }

    }
}
