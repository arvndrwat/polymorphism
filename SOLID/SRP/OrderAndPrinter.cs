using System;

namespace SOLID.SRP
{
    public class Order { public int Id { get; set; } public decimal Amount { get; set; } }

    public class OrderPrinter
    {
        public void Print(Order order) => Console.WriteLine($"Order {order.Id} Amount {order.Amount}");
    }

    public static class SrpDemo { public static void Run() { var o = new Order { Id = 1, Amount = 99.9m }; new OrderPrinter().Print(o); } }
}
