using System;
using System.Collections.Generic;

// SOLID examples with short real-world scenarios and minimal code.

namespace SOLID
{
    // Single Responsibility Principle (SRP)
    // Scenario: An Order has data. OrderPrinter is responsible only for printing.
    public class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
    }

    public class OrderPrinter
    {
        public void Print(Order order)
        {
            Console.WriteLine($"Order {order.Id}: Amount={order.Amount}");
        }
    }

    // Open/Closed Principle (OCP)
    // Scenario: Discount strategy for Orders. We can add new strategies without modifying existing code.
    public interface IDiscountStrategy
    {
        decimal Apply(decimal amount);
    }

    public class NoDiscount : IDiscountStrategy { public decimal Apply(decimal amount) => amount; }
    public class SeasonalDiscount : IDiscountStrategy { public decimal Apply(decimal amount) => amount * 0.9m; }

    public class Checkout
    {
        private readonly IDiscountStrategy _discount;
        public Checkout(IDiscountStrategy discount) { _discount = discount; }
        public decimal Total(Order order) => _discount.Apply(order.Amount);
    }

    // Liskov Substitution Principle (LSP)
    // Scenario: Bird and FlyingBird. A Penguin is a Bird but cannot fly — substituting a Penguin where a FlyingBird is required breaks LSP.
    public class Bird { public virtual void Eat() => Console.WriteLine("Bird eats"); }
    public class FlyingBird : Bird { public virtual void Fly() => Console.WriteLine("Bird flies"); }
    public class Sparrow : FlyingBird { public override void Fly() => Console.WriteLine("Sparrow flies"); }
    public class Penguin : Bird { /* Penguin cannot fly */ }

    // Interface Segregation Principle (ISP)
    // Scenario: Devices may not implement unnecessary members.
    public interface IPrinter { void Print(string content); }
    public interface IScanner { void Scan(); }
    public class MultiFunctionDevice : IPrinter, IScanner
    {
        public void Print(string content) => Console.WriteLine("Printing: " + content);
        public void Scan() => Console.WriteLine("Scanning document");
    }

    // Dependency Inversion Principle (DIP)
    // Scenario: High-level module Checkout depends on abstraction IEmailService rather than concrete implementation.
    public interface IEmailService { void Send(string to, string body); }
    public class SmtpEmailService : IEmailService { public void Send(string to, string body) => Console.WriteLine($"SMTP: Sent to {to}"); }

    public class NotificationSender
    {
        private readonly IEmailService _email;
        public NotificationSender(IEmailService email) { _email = email; }
        public void Notify(string to, string message) => _email.Send(to, message);
    }

    public static class SOLIDExamples
    {
        public static void Run()
        {
            Console.WriteLine("SRP example:");
            var order = new Order{ Id = 1, Amount = 100 };
            new OrderPrinter().Print(order);

            Console.WriteLine("OCP example:");
            var checkout = new Checkout(new SeasonalDiscount());
            Console.WriteLine($"Total: {checkout.Total(order)}");

            Console.WriteLine("LSP example:");
            List<Bird> birds = new List<Bird> { new Sparrow(), new Penguin() };
            foreach(var b in birds) b.Eat();

            Console.WriteLine("ISP example:");
            var mfd = new MultiFunctionDevice();
            mfd.Print("Hello"); mfd.Scan();

            Console.WriteLine("DIP example:");
            var sender = new NotificationSender(new SmtpEmailService());
            sender.Notify("bob@example.com", "Welcome");
        }
    }
}
