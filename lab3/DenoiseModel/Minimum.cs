using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenoiseModel
{
    internal class Minimum
    {
        public static Bitmap Execute(Bitmap sourceImage)
        {
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            Bitmap resImage = new Bitmap(width, height);
           

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    Color Color = CalculateNewPixelColor(sourceImage, x, y);
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

        public static Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radius = 1; // радиус матрицы
            int matrixSize = (1 + 2 * radius) * (1 + 2 * radius);

            byte min = 255;


            for (int l = -radius; l <= radius; l++)
                for (int k = -radius; k <= radius; k++)
                {
                    int idX = clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    if (GetBrightness(neighborColor) < min) min = GetBrightness(neighborColor);
                }

            return Color.FromArgb(min, min,min);

        }



        public static byte GetBrightness(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
    }
}
