# Polymorphism Repository — OOP & SOLID Examples

This repository contains simple, real-world C# examples demonstrating core OOP concepts (Inheritance, Polymorphism, Encapsulation, Abstraction, Interfaces) and the SOLID principles. Each example is written to be easy to read, explained with a real-life analogy, and structured so you can copy the classes into a console project or use them as learning material.

Structure
- README.md — this file
- Program.cs — runner that demonstrates each example
- Examples/
  - Polymorphism/PolymorphismExample.cs
  - Inheritance/InheritanceExample.cs
  - Encapsulation/EncapsulationExample.cs
  - Abstraction/AbstractionExample.cs
  - CompositionVsInheritance/CompositionExample.cs
- SOLID/
  - SRP/OrderAndPrinter.cs
  - OCP/DiscountStrategy.cs
  - LSP/BirdExample.cs
  - ISP/DeviceExample.cs
  - DIP/NotificationSenderExample.cs

How to use
1. dotnet new console -n OopExamples (if creating a fresh project)
2. Copy the Examples/ and SOLID/ folders into the project
3. Replace Program.cs with the included Program.cs or call specific Run() methods
4. dotnet run

Interview guidance
- Each example contains a real-life analogy and a few follow-up questions you can ask in interviews.
- Common pitfalls are documented (e.g., Rectangle/Square LSP example).

Contributions
- Add more scenarios, unit tests, and DI examples.
