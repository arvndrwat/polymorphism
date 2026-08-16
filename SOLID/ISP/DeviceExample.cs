using System;

namespace SOLID.ISP
{
    public interface IPrinter { void Print(string c); }
    public interface IScanner { void Scan(); }
    public class MultiFunction : IPrinter, IScanner { public void Print(string c) => Console.WriteLine("Print: " + c); public void Scan() => Console.WriteLine("Scan"); }

    public static class IspDemo { public static void Run() { var d = new MultiFunction(); d.Print("doc"); d.Scan(); } }
}
