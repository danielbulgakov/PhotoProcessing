using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class Global
    {

        public static Bitmap Execute(Bitmap sourceImage)
        {
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            Bitmap resImage = new Bitmap(width, height);

            //Вычислить гистограмму.
            int[] hist = CalculateHistogram(sourceImage);

            // Отсечь 5% от мин и макс пикселей.
            int min = hist.Where(x => x != 0).DefaultIfEmpty().Min();
            //hist[Array.IndexOf(hist, min)] = (int)(min * 0.95);
            int max = hist.Where(x => x != 0).DefaultIfEmpty().Max();
            //hist[Array.IndexOf(hist, max)] = (int)(max * 0.95);

            int mid = max - min;


            // Найти взвешенное среднее
            int t = 0;
            for (int i = 0; i < 255; i++)
            {
                if (hist[i] == 0) continue;
                t += (int) (hist[i] * i / hist.Sum());
            }



            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    Color color = sourceImage.GetPixel(x, y);
                    if (color.R >= t) resImage.SetPixel(x, y, Color.White);
                    else resImage.SetPixel(x, y, Color.Black);

                }



            return resImage;
        }

        public static int[] CalculateHistogram(Bitmap image)
        {
            int[] hist = new int[256];

            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = image.GetPixel(x, y);
                    hist[color.R]++;
                }

            return hist;
        }

        public static byte clamp(float value, float min, float max)
        {
            return (byte)(Math.Min(Math.Max(min, value), max));
        }

        public static int clamp(int value, int min, int max)
        {
            return (int)(Math.Min(Math.Max(min, value), max));
        }

    
    }
}
