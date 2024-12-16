using System.Drawing;

namespace EdgeDetection.Utils
{
    public static class ImageSaver
    {
        public static void SaveImage(byte[] data, int width, int height, string outputPath)
        {
            using (Bitmap bmp = new Bitmap(width, height))
            {
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        byte val = data[y * width + x];
                        bmp.SetPixel(x, y, Color.FromArgb(val, val, val));
                    }
                }
                bmp.Save(outputPath);
            }
        }
    }
}
