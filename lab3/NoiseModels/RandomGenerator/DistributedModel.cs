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
    }
}
