using System;
using EdgeDetection.Operators;
using EdgeDetection.Services;
using EdgeDetection.Utils;

namespace EdgeDetection
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Usage: EdgeDetection <inputImage> <outputImage> <operator>");
                Console.WriteLine("<operator> should be 'sobel' or 'prewitt'");
                return;
            }

            string inputPath = args[0];
            string outputPath = args[1];
            string operatorName = args[2].ToLower();

            IEdgeDetector detector = operatorName switch
            {
                "sobel" => new SobelEdgeDetector(),
                "prewitt" => new PrewittEdgeDetector(),
                _ => throw new ArgumentException("Invalid operator. Use 'sobel' or 'prewitt'.")
            };

            var (data, width, height) = ImageLoader.LoadImage(inputPath);
            var service = new EdgeDetectionService(detector);

            var result = service.DetectEdges(data, width, height);
            ImageSaver.SaveImage(result, width, height, outputPath);

            Console.WriteLine("Edge detection completed successfully.");
        }
    }
}
