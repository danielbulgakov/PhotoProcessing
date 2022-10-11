using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseModels
{

    internal class Uniform
    {
        static double a = 32;
        static double b = 64;


        public static Bitmap Execute(Bitmap sourceImage)
        {
             return  AdditiveModel.CalculateBitmap(sourceImage, ComputeUniform(sourceImage.Width * sourceImage.Height));
        }

        protected static float[] ComputeUniform(int size)
        {
            var uniform = new float[256];
            float sum = 0f;

            for (int i = 0; i < 256; i++)
            {
                float step = i;
                if (step >= a && step <= b)
                {
                    uniform[i] = (1 / (float)(b - a));
                }
                else
                {
                    uniform[i] = 0;
                }
                sum += uniform[i];
            }

            for (int i = 0; i < 256; i++)
            {
                uniform[i] /= sum;
                uniform[i] *= size;
                uniform[i] = (int)Math.Floor(uniform[i]);
            }


            return uniform;
        }
    }
}
