using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class Niblack
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
            float constant = -0.2f; // коэфициент
            int radius = 1; // радиус матрицы
            int matrixSize = (1 + 2 * radius) * (1 + 2 * radius);

            int intesitySum = 0; // сумма яркостей
            int resultI; // результат нахождения среднего

            int newResult = 0; // новая сумма яркостей
            int deviation; // результат нахождения отклонения 

            for (int l = -radius; l <= radius; l++)
                for (int k = -radius; k <= radius; k++)
                {
                    int idX = clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    intesitySum += (int)neighborColor.R;
                    
                }

            resultI = (int)(intesitySum / matrixSize);

            for (int l = -radius; l <= radius; l++)
                for (int k = -radius; k <= radius; k++)
                {
                    int idX = clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    newResult += (int)Math.Pow(neighborColor.R - resultI, 2);

                }

            deviation = (int)Math.Sqrt(newResult / matrixSize);

            byte T = (byte)(resultI + (byte)(constant * deviation));
            

            Color color = sourceImage.GetPixel(x, y);
            if (color.R >= T) return Color.White;
            else return Color.Black;
            
        }
    }
}
