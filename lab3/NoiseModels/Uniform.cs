using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseModels
{

    internal class Uniform : DistributedModel
    {
        static int a = 64;
        static int b = 32;

        static double[] uniform = new double[256];
        static double sum = 0;
        static int size;
        static byte[] noise;

        public static Bitmap Execute(Bitmap sourceImage, byte upBorder = 255, byte downBorder = 0)
        {
            Bitmap resImage = new Bitmap(sourceImage);
            size = sourceImage.Width * sourceImage.Height;
            noise = new byte[size];

            
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color color = sourceImage.GetPixel(x, y);
                    int add = GetBrightness(color) + noise[sourceImage.Width * y + x];
                    byte v = clamp(GetBrightness(color) + add, 0, 255);
                    Color newColor = Color.FromArgb(v,v,v);
                    resImage.SetPixel(x, y, newColor);

                }


            return resImage;
        }

        public static byte clamp(float value, float min, float max)
        {
            return (byte)(Math.Min(Math.Max(min, value), max));
        }


        private static void ComputeUniform()
        {
            for (int i = 0; i < 256; i++)
            {
                double step = (double)i;
                if (step >= a && step <= b)
                {
                    uniform[i] = (double)(1 / (b - a));
                }
                else
                {
                    uniform[i] = 0;
                }
                sum += uniform[i];
            }
            for (int i = 0; i < 256; i++)
            {
                uniform[i] /= sum;
                uniform[i] *= size;
                uniform[i] = (int)Math.Floor(uniform[i]);
            }
        }

        private static void ComputeNoise()
        {
            Random rnd = new Random();
            int count = 0;
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < (int)uniform[i]; j++)
                {
                    noise[j + count] = (byte)i;
                }
                count += (int)uniform[i];
            }

            for (int i = 0; i < size - count; i++)
            {
                noise[count + i] = 0;
            }

            noise = noise.OrderBy(x => rnd.Next()).ToArray();
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
