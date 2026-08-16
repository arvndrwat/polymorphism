using System;

// Real-life analogy:
// Think of different types of notifications: Email, SMS, and Push.
// All notifications can be "Sent", but each type sends differently.
// This demonstrates runtime polymorphism via interfaces and virtual methods.

namespace Examples.Polymorphism
{
    public abstract class Notification
    {
        public string To { get; set; }
        public string Message { get; set; }

        // Base behavior: all notifications can Send
        public abstract void Send();
    }

    public class EmailNotification : Notification
    {
        public string Subject { get; set; }
        public override void Send()
        {
            Console.WriteLine($"Sending EMAIL to {To}: Subject='{Subject}' Message='{Message}'");
        }
    }

    public class SmsNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine($"Sending SMS to {To}: Message='{Message}'");
        }
    }

    public class PushNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine($"Sending PUSH to {To}: Message='{Message}'");
        }
    }

    public static class PolymorphismExample
    {
        // Steps to show polymorphism:
        // 1. Create a list/array of base type Notification
        // 2. Fill with different derived types
        // 3. Call Send() on each — runtime type decides which implementation runs
        public static void Run()
        {
            Notification[] notifications = new Notification[]
            {
                new EmailNotification{ To = "alice@example.com", Subject = "Hi", Message = "Welcome" },
                new SmsNotification{ To = "+15551234", Message = "Your code is 1234" },
                new PushNotification{ To = "device-abc", Message = "You have a meeting" }
            };

            foreach (var n in notifications)
            {
                n.Send();
            }
        }
    }
}
