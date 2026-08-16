using System;

namespace Examples.Abstraction
{
    public abstract class Appliance
    {
        public string Model { get; set; }
        public abstract void TurnOn();
        public abstract void TurnOff();
    }

    public class Television : Appliance
    {
        public override void TurnOn() => Console.WriteLine($"TV {Model} powering on...");
        public override void TurnOff() => Console.WriteLine($"TV {Model} powering off...");
    }

    public static class AbstractionExample
    {
        public static void Run()
        {
            Appliance tv = new Television { Model = "SuperView 42" };
            tv.TurnOn();
            tv.TurnOff();
        }
    }
}
