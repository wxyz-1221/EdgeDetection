using System.Drawing;

namespace EdgeDetection.Utils
{
    public static class ImageLoader
    {
        public static (byte[] data, int width, int height) LoadImage(string path)
        {
            using (Bitmap bmp = new Bitmap(path))
            {
                int width = bmp.Width;
                int height = bmp.Height;
                byte[] data = new byte[width * height];

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);
                        // Assuming grayscale or taking the red channel as intensity
                        data[y * width + x] = c.R;
                    }
                }

                return (data, width, height);
            }
        }
    }
}
