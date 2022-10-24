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
            float L = (float)(Math.Pow(2, 8) - 1f);
            float k1 = 0.01f, k2 = 0.03f;
            float c1 = (float)Math.Pow(k1 * L, 2);
            float c2 = (float)Math.Pow(k2 * L, 2);


            float meanX = ComputeMean(perfImage), meanY = ComputeMean(compareImage);
            float disX = ComputeDis(perfImage, meanX), disY = ComputeDis(compareImage, meanY);
            float covXY = ComputeCov(perfImage, meanX, compareImage, meanY);

            
            float ssim, dssim;

            ssim = (2 * meanX * meanY + c1)*(2*covXY + c2) /
                    (float)((Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + c1) * 
                    (Math.Pow(disX, 2) + Math.Pow(disY, 2) + c2)) ;

            dssim = (1 - ssim) / 2;

            return ssim;
        }

        private static float ComputeMean(Bitmap image)
        {
            float sum = 0f;
            for (int i = 0; i < image.Height; i++)
                for (int j = 0; j < image.Width; j++)
                {
                    sum += image.GetPixel(j, i).R;
                    sum += image.GetPixel(j, i).G;
                    sum += image.GetPixel(j, i).B;
                } 
            return (sum / (float)(image.Height * image.Width * 3));
        }

        private static float ComputeDis(Bitmap image, float mean)
        {
            float sum = 0f;
            for (int i = 0; i < image.Height; i++)
                for (int j = 0; j < image.Width; j++)
                {
                    sum += (float)Math.Pow(image.GetPixel(j, i).R - mean, 2);
                    sum += (float)Math.Pow(image.GetPixel(j, i).G - mean, 2);
                    sum += (float)Math.Pow(image.GetPixel(j, i).B - mean, 2);
                }
            return (float)Math.Sqrt(sum / ((float)(image.Height * image.Width) - 1f) * 3);
        }

        private static float ComputeCov(Bitmap im1, float m1, Bitmap im2, float m2)
        {
            float sum = 0f;
            for (int i = 0; i < im1.Height; i++)
                for (int j = 0; j < im1.Width; j++)
                {
                    sum += (im1.GetPixel(j, i).R - m1) * (im2.GetPixel(j, i).R - m2);
                    sum += (im1.GetPixel(j, i).G - m1) * (im2.GetPixel(j, i).G - m2);
                    sum += (im1.GetPixel(j, i).B - m1) * (im2.GetPixel(j, i).B - m2);
                }
            return (sum / ((float)(im1.Height * im1.Width) - 1f) * 3);
        }


        private static float GetBrightness(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
    }
}
