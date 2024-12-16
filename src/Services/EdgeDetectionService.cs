using EdgeDetection.Operators;

namespace EdgeDetection.Services
{
    public class EdgeDetectionService
    {
        private readonly IEdgeDetector _edgeDetector;

        public EdgeDetectionService(IEdgeDetector edgeDetector)
        {
            _edgeDetector = edgeDetector;
        }

        public byte[] DetectEdges(byte[] imageData, int width, int height)
        {
            return _edgeDetector.Apply(imageData, width, height);
        }
    }
}
