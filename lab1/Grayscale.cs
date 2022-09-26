using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class Grayscale
    {
        public static Bitmap Execute(Bitmap sourceImage)
        {
            Bitmap resImage = sourceImage;
            
            int width = resImage.Width;
            int height = resImage.Height;

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    Color color = resImage.GetPixel(x, y);
                    byte gray = (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
                    resImage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }

            return resImage;
        }
    }
}
