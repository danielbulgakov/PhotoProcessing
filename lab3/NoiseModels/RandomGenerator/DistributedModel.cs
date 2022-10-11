using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseModels
{
    internal class DistributedModel
    {
        static protected Tuple<int, int> GetNextRandPixel(int width, int height)
        {
            Random random = new Random();
            int x = random.Next(width);
            int y = random.Next(height);
            return new Tuple<int, int>(x, y);
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
