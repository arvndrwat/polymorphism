using System;

// Real-life analogy:
// An appliance (like a TV) exposes a simple interface: TurnOn, TurnOff.
// The internal implementation (how the remote sends signals) is hidden.

namespace Examples.Abstraction
{
    // Abstract class defines the contract
    public abstract class Appliance
    {
        public string Model { get; set; }
        public abstract void TurnOn();
        public abstract void TurnOff();
    }

    public class Television : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine($"Television {Model} is powering on...");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"Television {Model} is powering off...");
        }
    }

    public static class AbstractionExample
    {
        public static void Run()
        {
            Appliance tv = new Television{ Model = "SuperView 42" };
            tv.TurnOn();
            tv.TurnOff();
        }
    }
}
