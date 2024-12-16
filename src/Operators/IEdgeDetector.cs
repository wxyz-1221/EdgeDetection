namespace EdgeDetection.Operators
{

    public interface IEdgeDetector
    {
        byte[] Apply(byte[] input, int width, int height); 
    }
}
