using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseModels
{
    internal class Gaussian
    {
        public static Bitmap Execute(Bitmap sourceImage, byte upBorder = 255, byte downBorder = 0)
        {
            Bitmap resImage = new Bitmap(sourceImage);

            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color color = sourceImage.GetPixel(x, y);
                    resImage.SetPixel(x, y, CalculateColor(color, upBorder, downBorder));
                }
            return resImage;
        }

        public static Color CalculateColor(Color color, float mean, float mse)
        {
            float firstHalf = 1 / (float)Math.Sqrt(2 * Math.PI * mse);
            float pow = (float)(-(Math.Pow(GetBrightness(color) - mean, 2)) / (2 * Math.Pow(mse, 2)));
            float secondHalf = (float)Math.Pow(Math.E, pow);

            byte resV = (byte)(firstHalf * secondHalf);

            return Color.FromArgb(resV);
        }

        private static float ComputeMean(Bitmap image)
        {
            float sum = 0f;
            for (int i = 0; i < image.Height; i++)
                for (int j = 0; j < image.Width; j++)
                {
                    Color color = image.GetPixel(j, i);
                    sum += GetBrightness(color);
                }
            return sum / (image.Width * image.Height);
        }

        private static float ComputeMSE(Bitmap image, float mean)
        {
            float sum = 0f;
            for (int i = 0; i < image.Height; i++)
                for (int j = 0; j < image.Width; j++)
                {
                    Color color = image.GetPixel(i, j);
                    
                    sum += (float)Math.Pow(GetBrightness(color) - mean, 2);
                }
            return sum / (image.Width * image.Height);

        }

        public static byte GetBrightness(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
    }
}
