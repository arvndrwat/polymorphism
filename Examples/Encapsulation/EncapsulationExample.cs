using System;

namespace Examples.Encapsulation
{
    public class BankAccount
    {
        private decimal _balance;
        public string Owner { get; private set; }

        public BankAccount(string owner, decimal initial = 0)
        {
            Owner = owner;
            _balance = initial;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Deposit must be positive");
            _balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Withdraw must be positive");
            if (amount > _balance) return false;
            _balance -= amount;
            return true;
        }

        public decimal GetBalance() => _balance;
    }

    public static class EncapsulationExample
    {
        public static void Run()
        {
            var acct = new BankAccount("Ravi", 100);
            acct.Deposit(50);
            bool ok = acct.Withdraw(30);
            Console.WriteLine($"Owner:{acct.Owner}, Balance:{acct.GetBalance()}, WithdrawOK:{ok}");
        }
    }
}
