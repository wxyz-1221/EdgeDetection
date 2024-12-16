using Microsoft.VisualStudio.TestTools.UnitTesting;
using EdgeDetection.Operators;
using EdgeDetection.Services;

namespace EdgeDetection.Tests
{
    [TestClass]
    public class EdgeDetectionTests
    {
        [TestMethod]
        public void TestSobelOutputSize()
        {
            IEdgeDetector detector = new SobelEdgeDetector();
            var service = new EdgeDetectionService(detector);

            byte[] input = new byte[]
            {
                0, 50, 100,
                50,100,150,
                100,150,200
            };

            var output = service.DetectEdges(input, 3, 3);
            Assert.IsNotNull(output);
            Assert.AreEqual(input.Length, output.Length);
        }

        [TestMethod]
        public void TestPrewittOutputSize()
        {
            IEdgeDetector detector = new PrewittEdgeDetector();
            var service = new EdgeDetectionService(detector);

            byte[] input = new byte[]
            {
                0, 50, 100,
                50,100,150,
                100,150,200
            };

            var output = service.DetectEdges(input, 3, 3);
            Assert.IsNotNull(output);
            Assert.AreEqual(input.Length, output.Length);
        }
    }
}
