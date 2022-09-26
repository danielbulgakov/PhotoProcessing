using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class Autocontrast
    {
        public static Bitmap Execute(Bitmap sourceImage)
        {
            int width = sourceImage.Width;
            int height = sourceImage.Height;

            byte maxR = 0, maxG = 0, maxB = 0;
            byte minR = 255, minG = 255, minB = 255;

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    Color Color = sourceImage.GetPixel(x, y);

                    maxR = Math.Max(maxR, Color.R);
                    maxG = Math.Max(maxG, Color.G);
                    maxB = Math.Max(maxB, Color.B);

                    minR = Math.Min(minR, Color.R);
                    minG = Math.Min(minG, Color.G);
                    minB = Math.Min(minB, Color.B);

                }


            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    Color color = sourceImage.GetPixel(x, y);
                    byte R = (byte)((color.R - minR) * ((255f) / (float)(maxR - minR)));
                    byte G = (byte)((color.G - minG) * ((255f) / (float)(maxG - minG)));
                    byte B = (byte)((color.B - minB) * ((255f) / (float)(maxB - minB)));
                    sourceImage.SetPixel(x, y, Color.FromArgb(R, G, B));
                }


            return sourceImage;
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
