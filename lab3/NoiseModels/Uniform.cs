using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseModels
{
    internal class Uniform : DistributedModel
    {

        public static Bitmap Execute(Bitmap sourceImage, byte upBorder = 255, byte downBorder = 0)
        {
            Bitmap resImage = new Bitmap(sourceImage);

            const float p = 0.8f;
            int noisePixels = 0;
            while (noisePixels < sourceImage.Height * sourceImage.Width * p)
            {
                var pos = GetNextRandPixel(sourceImage.Width, sourceImage.Height);
                noisePixels++;
                Color color = sourceImage.GetPixel(pos.Item1, pos.Item2);
                resImage.SetPixel(pos.Item1, pos.Item2, CalculateColor(color, upBorder, downBorder));
            }

            
            return resImage;
        }

        public static Color CalculateColor(Color color, byte up, byte down)
        {
            if (GetBrightness(color) >= down &&
                GetBrightness(color) <= up)
                return Color.FromArgb((byte)(1 / up - down), (byte)(1 / up - down), (byte)(1 / up - down));

            return Color.Black;
        }

        public static byte GetBrightness(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
    }
}
