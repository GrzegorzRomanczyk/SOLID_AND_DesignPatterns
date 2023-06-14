using System;

namespace EmailSender_Good
{
    public class Logger : ILogger
    {
        public void LogError(Exception exception)
        {
            Console.WriteLine($"Error: {exception}");
        }
    }
}