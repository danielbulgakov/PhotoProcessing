using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageCompare
{
    internal class PSNR
    {
        private static float max = 255f;

        public static float Execute(Bitmap compareImage, Bitmap perfImage)
        {
            if (compareImage.Size != perfImage.Size) return -1;

            float mse = ComputeMSE(compareImage, perfImage);
            Console.WriteLine("MSE = " + mse.ToString());

            float psnr = (float)(20 * Math.Log10(max / (float)Math.Sqrt(mse)));
            return psnr;
            
        }

        private static float ComputeMSE(Bitmap im1, Bitmap im2)
        {
            float sum = 0f;
            for (int i = 0; i < im1.Height; i++)
                for (int j = 0; j < im1.Width; j++)
                {
                    sum += (float)Math.Pow((im1.GetPixel(j, i).R - im2.GetPixel(j, i).R), 2f);
                    sum += (float)Math.Pow((im1.GetPixel(j, i).G - im2.GetPixel(j, i).G), 2f);
                    sum += (float)Math.Pow((im1.GetPixel(j, i).B - im2.GetPixel(j, i).B), 2f);

                }


            return (sum / (float)(im1.Height * im1.Width * 3));
        }

       

    }
}
