using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenoiseModel
{
    internal class Gauss
    {
       

        public static Bitmap Execute(Bitmap sourceImage)
        {
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            Bitmap resImage = new Bitmap(width, height);
            



            int radius = 1;
            int sigma = 2;

            int size = 2 * radius + 1;
            float[,] kernel = new float[size, size];
            float norm = 0;

            for (int i = -radius; i <= radius; i++)
                for (int j = -radius; j <= radius; j++)
                {
                    kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    kernel[i, j] /= norm;

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    Color Color = CalculateNewPixelColor(sourceImage, kernel, x, y);
                    resImage.SetPixel(x, y, Color);

                }



            return resImage;
        }

        public static byte clamp(float value, float min, float max)
        {
            return (byte)(Math.Min(Math.Max(min, value), max));
        }

        public static int clamp(int value, int min, int max)
        {
            return (int)(Math.Min(Math.Max(min, value), max));
        }

        public static Color CalculateNewPixelColor(Bitmap sourceImage, float[,] kernel, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float res = 0;

            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    res += neighborColor.R * kernel[k + radiusX, l + radiusY];

                }
            return Color.FromArgb(clamp((int)res, 0, 255),
                                 clamp((int)res, 0, 255),
                                 clamp((int)res, 0, 255));

        }



        public static byte GetBrightness(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
    }
}
