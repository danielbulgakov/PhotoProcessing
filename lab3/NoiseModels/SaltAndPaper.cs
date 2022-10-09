using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseModels
{
    internal class SaltAndPaper
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

        public static Color CalculateColor(Color color, byte up, byte down)
        {
            if (GetBrightness(color) == up ||
                GetBrightness(color) == down)
                return color;
            else
                return Color.Black;
        }

        public static byte GetBrightness(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
    }
}
