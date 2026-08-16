using System;

namespace Examples.CompositionVsInheritance
{
    public class Engine
    {
        public void Start() => Console.WriteLine("Engine started");
    }

    public class Car
    {
        private readonly Engine _engine;
        public Car(Engine engine) => _engine = engine;
        public void Start() => _engine.Start();
    }

    public static class CompositionExample
    {
        public static void Run()
        {
            var engine = new Engine();
            var car = new Car(engine);
            car.Start();
        }
    }
}
