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

            Bitmap resImage = new Bitmap(width, height);

            byte maxIntensity = 0, minIntensity = 255;

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    Color color = sourceImage.GetPixel(x, y);

                    byte intensity = (byte)(.299 * color.R + .587 * color.G + .114 * color.B);

                    maxIntensity = Math.Max(maxIntensity, intensity);
                    minIntensity = Math.Min(minIntensity, intensity);

                }

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    Color color = sourceImage.GetPixel(x, y);

                    byte intensity = (byte)(.299 * color.R + .587 * color.G + .114 * color.B);

                    byte newIntensity = (byte)((intensity - minIntensity) * ((255f) / (float)(maxIntensity - minIntensity)));
                    byte R, G, B;

                    if (intensity == 0)
                    {
                        R = 0;
                        G = 0; 
                        B = 0;
                    }
                    else
                    {
                        R = (byte)(color.R * newIntensity / intensity);
                        G = (byte)(color.G * newIntensity / intensity);
                        B = (byte)(color.B * newIntensity / intensity);
                    }

                    resImage.SetPixel(x, y, Color.FromArgb(R, G, B));
                }

            return resImage;
        }


    }
}
