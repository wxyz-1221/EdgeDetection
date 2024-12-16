# EdgeDetection

A C# console application that applies edge detection on grayscale images using Sobel or Prewitt operators. 

## Description

EdgeDetection is a C# console application that applies edge detection filters to grayscale images.
It supports two popular gradient-based operators:
- **Sobel**: Detects edges by calculating the gradient in both the x and y directions.
- **Prewitt**: Similar to Sobel, but uses different convolution kernels for edge detection.

This tool is helpful for image processing tasks such as feature extraction, image segmentation, and computer vision applications.

## Requirements

- .NET 8.0 or newer
- A valid path to a grayscale input image.

## How to Run

1. **Clone the Repository**
```sh
git clone <repository_url>
cd <repository_folder>
```

2. **Navigate to the src folder and build**
```sh
cd src
dotnet restore
dotnet build
```

3. **Run the Application**

Using the Sobel Operator:
```sh
dotnet run --project EdgeDetection.csproj ./input/Phase.png ./output/Phase_sobel.png sobel
```

Using the Prewitt Operator:
```sh
dotnet run --project EdgeDetection.csproj ./input/Phase.png ./output/Phase_prewitt.png prewitt
```


Notes:

Replace ./input/Phase.png with the path to your input grayscale image.

Replace ./output/Phase_sobel.png with the desired path for the processed image.

## Testing

Navigate to the tests folder and execute:
```sh
cd tests
dotnet test
```







