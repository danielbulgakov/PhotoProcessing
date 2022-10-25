using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NoiseModels
{
    internal abstract class AdditiveModel
    {
        static float[] uni;
        static int[] uniint;

        public static Bitmap CalculateBitmap(Bitmap sourceImage, float[] uniform)
        {
            int size = sourceImage.Width * sourceImage.Height;
            uni = new float[uniform.Length];
            for (int i = 0; i < uniform.Length; i++) uni[i] = uniform[i];
            var noise = ComputeNoise(uniform, size);

            var resImage = new Bitmap(sourceImage);

            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color color = sourceImage.GetPixel(x, y);
                    


                    resImage.SetPixel(x, y, Color.FromArgb(clamp(color.R + noise[sourceImage.Width * y + x], 0, 255),
                        clamp(color.G + noise[sourceImage.Width * y + x], 0, 255),
                        clamp(color.B + noise[sourceImage.Width * y + x], 0, 255)));

                }


            return resImage;
        }

        

        public static int[] CalculateHistogram()
        {
            uniint = new int[uni.Length];
            for (int i = 0; i < uni.Length; i++)
                uniint[i] = (int)uni[i];
            return uniint;
        }


        protected static byte[] ComputeNoise(float[] uniform, int size)
        {
            Random random = new Random();
            int count = 0;
            var noise = new byte[size];
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

            noise = noise.OrderBy(x => random.Next()).ToArray();
            return noise;
        }

        public static byte clamp(float value, float min, float max)
        {
            return (byte)(Math.Min(Math.Max(min, value), max));
        }

        public static byte GetBrightness(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
    }
}
