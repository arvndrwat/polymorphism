using System;

namespace SOLID.OCP
{
    public interface IDiscount { decimal Apply(decimal amount); }
    public class NoDiscount : IDiscount { public decimal Apply(decimal a) => a; }
    public class SeasonalDiscount : IDiscount { public decimal Apply(decimal a) => a * 0.9m; }

    public class Checkout
    {
        private readonly IDiscount _discount;
        public Checkout(IDiscount discount) => _discount = discount;
        public decimal Total(decimal amount) => _discount.Apply(amount);
    }

    public static class OcpDemo { public static void Run() { var co = new Checkout(new SeasonalDiscount()); Console.WriteLine(co.Total(100)); } }
}
