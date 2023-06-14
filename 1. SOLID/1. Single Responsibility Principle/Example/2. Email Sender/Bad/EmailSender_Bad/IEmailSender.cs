using System;

namespace EmailSender_Bad
{
    public interface IEmailSender
    {
        void AddToStats();

        void LogError(Exception exception);

        void Send();
    }
}