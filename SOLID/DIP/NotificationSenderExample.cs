using System;

namespace SOLID.DIP
{
    public interface IEmailService { void Send(string to, string body); }
    public class SmtpEmailService : IEmailService { public void Send(string to, string body) => Console.WriteLine($"SMTP -> {to}: {body}"); }
    public class MockEmailService : IEmailService { public void Send(string to, string body) => Console.WriteLine($"[MOCK] {to}: {body}"); }

    public class NotificationSender
    {
        private readonly IEmailService _email;
        public NotificationSender(IEmailService email) => _email = email;
        public void Notify(string to, string msg) => _email.Send(to, msg);
    }

    public static class DipDemo { public static void Run() { var sender = new NotificationSender(new MockEmailService()); sender.Notify("bob@example.com", "Welcome"); } }
}
