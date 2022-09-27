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

            int histSum = hist.Sum();
            int cut = (int)(histSum * 0.05);
            
            for (int i = 0; i < 255; i++)
            {
                if (hist[i] < cut)
                {
                    cut -= hist[i];
                    hist[i] = 0;
                }
                else
                {
                    hist[i] -= cut;
                }
                if (cut == 0) break;
                
            }

            cut = (int)(histSum * 0.05);

            for (int i = 255; i < 0; i--)
            {
                if (hist[i] < cut)
                {
                    cut -= hist[i];
                    hist[i] = 0;
                }
                else
                {
                    hist[i] -= cut;
                }
                if (cut == 0) break;

            }

            // Найти взвешенное среднее
            int t = 0;

            int weight = 0;
            for (int i = 0; i < 255; i++)
            {
                if (hist[i] == 0) continue;

                weight += hist[i] * i;
            }

            // Вычисление порога
            t = (int)(weight / hist.Sum());

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

        

    
    }
}
