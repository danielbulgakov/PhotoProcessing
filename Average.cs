using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class Average
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
            int ct = 0;
            int radiusX = 1;
            int radiusY = radiusX;

            byte resultR = 0;
            byte resultG = 0;
            byte resultB = 0;

            byte[] R = new byte[9];
            byte[] G = new byte[9];
            byte[] B = new byte[9];

            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    R[ct] = neighborColor.R;
                    G[ct] = neighborColor.G;
                    B[ct] = neighborColor.B;
                    ct++;
                }

            resultR = (byte)(Math.Round((decimal)(R.Select(el => (int)el).Sum()) / R.Length));
            resultG = (byte)(Math.Round((decimal)(G.Select(el => (int)el).Sum()) / G.Length));
            resultB = (byte)(Math.Round((decimal)(B.Select(el => (int)el).Sum()) / B.Length));

            return Color.FromArgb(resultR, resultG, resultB);

        }
    }
}
