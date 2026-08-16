# Polymorphism Repository — OOP & SOLID Examples

This repository contains simple, real-world C# examples demonstrating core OOP concepts (Inheritance, Polymorphism, Encapsulation, Abstraction, Interfaces) and the SOLID principles. Each example is written to be easy to read, explained with a real-life analogy, and structured so you can copy the classes into a console project or use them as learning material.

Structure
- README.md — this file
- Program.cs — original polymorphism demo (left as-is)
- Examples/
  - Polymorphism/PolymorphismExample.cs
  - Inheritance/InheritanceExample.cs
  - Encapsulation/EncapsulationExample.cs
  - Abstraction/AbstractionExample.cs
- SOLID/
  - SOLIDExamples.cs

How to use
- These example files contain classes and static Run() methods. To run any example:
  1. Create a new Console project: `dotnet new console -n OopExamples`
  2. Copy one example file into the project (Examples/... or SOLID/...).
  3. In `Program.cs` call the example's Run() method (e.g., `PolymorphismExample.Run();`).
  4. `dotnet run`

Guidelines
- Each example includes a short real-world analogy and step-by-step explanation.
- Examples are intentionally small and focused so they can be used in interviews or teaching.

Contributions
- Add more scenarios with comments and small tests.
- Add unit tests or a sample console runner combining all examples.
