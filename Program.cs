using System;
using Examples.Polymorphism;
using Examples.Inheritance;
using Examples.Encapsulation;
using Examples.Abstraction;
using Examples.CompositionVsInheritance;
using SOLID.SRP;
using SOLID.OCP;
using SOLID.LSP;
using SOLID.ISP;
using SOLID.DIP;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Polymorphism ==="); Examples.Polymorphism.PolymorphismExample.Run();
        Console.WriteLine();

        Console.WriteLine("=== Inheritance ==="); Examples.Inheritance.InheritanceExample.Run();
        Console.WriteLine();

        Console.WriteLine("=== Encapsulation ==="); Examples.Encapsulation.EncapsulationExample.Run();
        Console.WriteLine();

        Console.WriteLine("=== Abstraction ==="); Examples.Abstraction.AbstractionExample.Run();
        Console.WriteLine();

        Console.WriteLine("=== Composition (preferred over improper inheritance) ==="); Examples.CompositionVsInheritance.CompositionExample.Run();
        Console.WriteLine();

        Console.WriteLine("=== SOLID Examples ===");
        SOLID.SRP.SrpDemo.Run();
        SOLID.OCP.OcpDemo.Run();
        SOLID.LSP.LspDemo.Run();
        SOLID.ISP.IspDemo.Run();
        SOLID.DIP.DipDemo.Run();
    }
}
