EdgeDetection

Description

EdgeDetection is a C# console application that performs edge detection on grayscale images using either the Sobel or Prewitt operators. The user can specify which operator to use via command-line arguments.

Requirements

.NET 8.0 or newer

Ensure System.Drawing.Common is installed (this will be automatically handled by dotnet restore).

How to Run

1. Clone the Repository

git clone <repository_url>
cd <repository_folder>

2. Navigate to the src Folder and Restore Dependencies

cd src
dotnet restore
dotnet build

3. Run the Application

You can run the application with the following commands:

Using the Sobel Operator

dotnet run --project ./src/EdgeDetection.csproj input.png output.png sobel

Using the Prewitt Operator

dotnet run --project ./src/EdgeDetection.csproj input.png output.png prewitt

Notes:

Replace input.png with the path to your input grayscale image.

Replace output.png with the desired path for the processed image.

Testing

Run Unit Tests

Navigate to the tests folder and execute the tests:

cd tests
dotnet test

Folder Structure

EdgeDetection/
├─ src/
│  ├─ EdgeDetection.csproj
│  ├─ Program.cs
│  ├─ Operators/
│  │  ├─ IEdgeDetector.cs
│  │  ├─ SobelEdgeDetector.cs
│  │  ├─ PrewittEdgeDetector.cs
│  ├─ Services/
│  │  ├─ EdgeDetectionService.cs
│  ├─ Utils/
│  │  ├─ ImageLoader.cs
│  │  ├─ ImageSaver.cs
│
├─ tests/
│  ├─ EdgeDetection.Tests.csproj
│  ├─ OperatorSelectionTests.cs
│  ├─ EdgeDetectionTests.cs
│
├─ UML/
│  ├─ diagram.drawio
│
├─ README.md



