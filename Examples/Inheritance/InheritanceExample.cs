using System;

namespace Examples.Inheritance
{
    public class Vehicle
    {
        public int Speed { get; set; }
        public virtual void Move() => Console.WriteLine($"Vehicle is moving at {Speed} km/h");
    }

    public class Car : Vehicle
    {
        public int Passengers { get; set; }
        public override void Move() => Console.WriteLine($"Car with {Passengers} passengers drives at {Speed} km/h");
    }

    public class Bicycle : Vehicle
    {
        public bool HasBell { get; set; }
        public override void Move() => Console.WriteLine($"Bicycle pedals at {Speed} km/h {(HasBell ? "(rings bell)" : "")}");
    }

    public static class InheritanceExample
    {
        public static void Run()
        {
            Vehicle v1 = new Car { Speed = 80, Passengers = 4 };
            Vehicle v2 = new Bicycle { Speed = 15, HasBell = true };

            v1.Move();
            v2.Move();
        }
    }
}
