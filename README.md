## DCIT 318: Programming II – Assignment 2

This repository contains three small C# console applications that demonstrate core OOP concepts: inheritance and method overriding, abstract classes, and interfaces.

### Projects
- **AnimalSoundApp**: Demonstrates inheritance and method overriding using `Animal`, `Dog`, and `Cat` with a `MakeSound()` method.
- **ShapesAreaCalculator**: Demonstrates abstract classes with an abstract `Shape` type and concrete `Circle` and `Rectangle` implementing `GetArea()`.
- **VehiclesAndBicyclesMover**: Demonstrates interfaces with an `IMovable` contract implemented by `Car` and `Bicycle`.

### Prerequisites
- .NET SDK 8.x or compatible

### How to build and run
From the repository root, you can run each project either by changing directory or by specifying the project path.

1) AnimalSoundApp
```powershell
cd AnimalSoundApp
dotnet run
```
Expected output:
```
Some generic sound
Bark
Meow
```

2) ShapesAreaCalculator
```powershell
cd ..\ShapesAreaCalculator
dotnet run
```
Expected output (values may vary with formatting):
```
Circle area: 78.54
Rectangle area: 24.00
```

3) VehiclesAndBicyclesMover
```powershell
cd ..\VehiclesAndBicyclesMover
dotnet run
```
Expected output:
```
Car is moving
Bicycle is moving
```

### Solution file
- `Assignment2Solution.sln` includes all three projects, so you can also work from the solution level in IDEs like Visual Studio or VS Code.

### Notes
- Code is intentionally concise and includes comments explaining the OOP concepts being demonstrated.