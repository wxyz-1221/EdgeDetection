# Project Name
EdgeDetection

## Description
A C# console application that performs edge detection on a grayscale image using Sobel or Prewitt operators, chosen by user input.

## Requirements
- .NET 8.0 or newer
- Ensure `System.Drawing.Common` is installed (handled by `dotnet restore`).

## How to Run
1. Clone the repository.
2. Navigate to `src` folder, restore and build:
   ```bash
   dotnet restore
   dotnet build

3. Run the application:
```bash
dotnet run --project ./src/EdgeDetection.csproj input.png output.png sobel
or
dotnet run --project ./src/EdgeDetection.csproj input.png output.png prewitt

## Testing
Navigate to `tests` folder:
```bash
dotnet test

