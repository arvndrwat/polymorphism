using System;

// Real-life analogy:
// A Vehicle is a general concept, and Car and Bicycle are specific kinds of vehicles.
// They inherit shared data/behavior (like Move) but can extend or override it.

namespace Examples.Inheritance
{
    public class Vehicle
    {
        public int Speed { get; set; }
        public virtual void Move()
        {
            Console.WriteLine($"Vehicle is moving at {Speed} km/h");
        }
    }

    public class Car : Vehicle
    {
        public int PassengerCapacity { get; set; }
        public override void Move()
        {
            Console.WriteLine($"Car with {PassengerCapacity} passengers drives at {Speed} km/h");
        }
    }

    public class Bicycle : Vehicle
    {
        public bool HasBell { get; set; }
        public override void Move()
        {
            Console.WriteLine($"Bicycle pedals at {Speed} km/h {(HasBell?"and rings bell":"")}");
        }
    }

    public static class InheritanceExample
    {
        // Steps:
        // 1. Create instances of derived classes
        // 2. Use base type references or derived references
        // 3. Observe overridden behavior
        public static void Run()
        {
            Vehicle v1 = new Car{ Speed = 80, PassengerCapacity = 4 };
            Vehicle v2 = new Bicycle{ Speed = 15, HasBell = true };

            v1.Move();
            v2.Move();
        }
    }
}
