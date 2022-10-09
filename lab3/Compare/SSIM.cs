using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageCompare
{
    internal class SSIM
    {
        public static float Execute(Bitmap compareImage, Bitmap perfImage)
        {
            const int L = 8; // bpp
            const float k1 = 0.01f;
            const float k2 = 0.03f;

            float c1 = (float)Math.Pow(L * k1, 2);
            float c2 = (float)Math.Pow(L * k2, 2);

            float comM = ComputeMean(compareImage);
            float perfM = ComputeMean(perfImage);

            float comVar = ComputeVariance(compareImage, comM);
            float perfVar = ComputeVariance(perfImage, perfM);

            float covar = ComputeCovariance(compareImage, perfImage, comVar, perfVar);

            float up = (2 * comM * perfM + c1) * (2 * covar + c2);
            float down = (comM * comM + perfM * perfM + c1) *
                    (comVar * comVar + perfVar * perfVar + c2);

            float ssim =  up / down;

            return (1 - ssim) / 2;
        }

        public static float ComputeMean(Bitmap image)
        {
            float sum = 0f;
            for (int i = 0; i < image.Height; i++)
                for (int j = 0; j < image.Width; j++)
                {
                    Color color = image.GetPixel(j, i);
                    sum += GetValue(color);
                }
            return sum / (image.Width * image.Height);
        }

        public static float ComputeVariance(Bitmap image, float mean)
        {
            float sum = 0f;
            for (int i = 0; i < image.Height; i++)
                for (int j = 0; j < image.Width; j++)
                {
                    Color color = image.GetPixel(j, i);
                    sum += (float)Math.Pow((GetValue(color) - mean), 2);
                }
            return (float)Math.Sqrt(sum / ((image.Width * image.Height - 1)));
        }

        public static float ComputeCovariance(Bitmap image1, Bitmap image2, float var1, float var2)
        {
            float sum = 0f;
            for (int i = 0; i < image1.Height; i++)
                for (int j = 0; j < image1.Width; j++)
                {
                    Color color1 = image1.GetPixel(j, i);
                    Color color2 = image2.GetPixel(j, i);
                    sum += (GetValue(color1) - var1) * (GetValue(color2) - var2);
                }
            return (float)Math.Sqrt(sum / ((image1.Width * image1.Height - 1)));
        }

        public static float GetValue(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
    }
}
