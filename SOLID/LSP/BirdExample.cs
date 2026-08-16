using System;

namespace SOLID.LSP
{
    public class Bird { public virtual void Eat() => Console.WriteLine("Bird eats"); }
    public class FlyingBird : Bird { public virtual void Fly() => Console.WriteLine("Bird flies"); }
    public class Sparrow : FlyingBird { public override void Fly() => Console.WriteLine("Sparrow flies"); }
    public class Penguin : Bird { /* cannot fly */ }

    public static class LspDemo
    {
        public static void Run()
        {
            Bird[] birds = new Bird[] { new Sparrow(), new Penguin() };
            foreach (var b in birds) b.Eat();
            // Avoid calling Fly on Bird—prefer separate abstraction for flying
        }
    }
}
