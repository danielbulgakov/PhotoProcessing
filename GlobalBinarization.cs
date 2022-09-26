using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class GlobalBinarization
    {
        public static Bitmap Execute(Bitmap sourceImage, int value)
        {
            Bitmap resImage = sourceImage;

            // Так как изображение исходное в оттенках серого, значит можно взять для сравнения любой канал.
            // В данном коде взят красный канал.

            int width = resImage.Width;
            int height = resImage.Height;

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    Color color = resImage.GetPixel(x, y);
                    if (color.R >= value)
                    {
                        resImage.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        resImage.SetPixel(x, y, Color.Black);
                    }
                    
                }

            return resImage;
        }
    }
}
