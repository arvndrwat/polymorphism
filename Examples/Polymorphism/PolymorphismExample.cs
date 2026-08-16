using System;

namespace Examples.Polymorphism
{
    public abstract class Notification
    {
        public string To { get; set; }
        public string Message { get; set; }
        public abstract void Send();
    }

    public class EmailNotification : Notification
    {
        public string Subject { get; set; }
        public override void Send()
        {
            Console.WriteLine($"[EMAIL] To:{To} Subject:'{Subject}' Message:'{Message}'");
        }
    }

    public class SmsNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine($"[SMS] To:{To} Message:'{Message}'");
        }
    }

    public class PushNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine($"[PUSH] To:{To} Message:'{Message}'");
        }
    }

    public static class PolymorphismExample
    {
        public static void Run()
        {
            Notification[] items = new Notification[]
            {
                new EmailNotification{ To="alice@example.com", Subject="Welcome", Message="Hello Alice" },
                new SmsNotification{ To="+15551234", Message="Your OTP is 1234" },
                new PushNotification{ To="device-1", Message="You have a new message" }
            };

            foreach (var n in items)
                n.Send();
        }
    }
}
