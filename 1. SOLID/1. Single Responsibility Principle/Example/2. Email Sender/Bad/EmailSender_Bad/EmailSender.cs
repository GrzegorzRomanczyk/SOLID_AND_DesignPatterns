using System;

namespace EmailSender_Bad
{
    public class EmailSender : IEmailSender
    {
        public void AddToStats()
        {
            Console.WriteLine("Added to stats");
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine($"Error: {exception}");
        }

        public void Send()
        {
            Console.WriteLine("Email sended");
        }
    }
}