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
        public static float Execute(Bitmap compareImage, Bitmap perfImage)
        {
            if (compareImage.Size != perfImage.Size) return -1;

            float mse = ComputeMSE(compareImage, perfImage);

            float psnr = (float)(20 * Math.Log10(255f / Math.Sqrt(mse)));
            return psnr;
            
        }

        private static float ComputeMSE(Bitmap compareImage, Bitmap perfImage)
        {
            float sum = 0f;
            for (int i = 0; i < perfImage.Height; i++)
                for (int j = 0; j < perfImage.Width; j++)
                {
                    Color perfColor = perfImage.GetPixel(i, j);
                    Color compareColor = compareImage.GetPixel(i, j);
                    sum += CompareColors(compareColor, perfColor);
                }
            return sum / (compareImage.Width * compareImage.Height);

        }

        private static float CompareColors (Color a, Color b)
        {
            return (float)Math.Pow(GetBrightness(a) - GetBrightness(b),2); 
        }

        private static float GetBrightness(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }

    }
}
