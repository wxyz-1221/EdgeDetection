using Microsoft.VisualStudio.TestTools.UnitTesting;
using EdgeDetection.Operators;

namespace EdgeDetection.Tests
{
    [TestClass]
    public class OperatorSelectionTests
    {
        [TestMethod]
        public void TestSobelOperatorInstance()
        {
            IEdgeDetector detector = new SobelEdgeDetector();
            Assert.IsNotNull(detector);
            Assert.IsInstanceOfType(detector, typeof(SobelEdgeDetector));
        }

        [TestMethod]
        public void TestPrewittOperatorInstance()
        {
            IEdgeDetector detector = new PrewittEdgeDetector();
            Assert.IsNotNull(detector);
            Assert.IsInstanceOfType(detector, typeof(PrewittEdgeDetector));
        }
    }
}

