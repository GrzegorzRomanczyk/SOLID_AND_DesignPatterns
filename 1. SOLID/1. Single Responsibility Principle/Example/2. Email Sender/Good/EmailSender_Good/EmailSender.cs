using System;

namespace EmailSender_Good
{
    public class EmailSender : IEmailSender
    {
        public void Send()
        {
            Console.WriteLine("Email sended");
        }
    }
}