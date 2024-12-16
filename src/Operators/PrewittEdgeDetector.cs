using System;

namespace EdgeDetection.Operators
{
    public class PrewittEdgeDetector : IEdgeDetector
    {
        private int[,] Gx = new int[,] {
            {-1, 0, 1},
            {-1, 0, 1},
            {-1, 0, 1}
        }; 

        private int[,] Gy = new int[,] {
            {-1,-1,-1},
            { 0, 0, 0},
            { 1, 1, 1}
        };

        public byte[] Apply(byte[] input, int width, int height)
        {
            byte[] output = new byte[width * height];

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int gx = 0;
                    int gy = 0;

                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            int pixel = input[(y + ky) * width + (x + kx)];
                            gx += pixel * Gx[ky + 1, kx + 1];
                            gy += pixel * Gy[ky + 1, kx + 1];
                        }
                    }

                    int g = (int)Math.Sqrt(gx * gx + gy * gy);
                    if (g > 255) g = 255;
                    output[y * width + x] = (byte)g;
                }
            }

            return output;
        }
    }
}
