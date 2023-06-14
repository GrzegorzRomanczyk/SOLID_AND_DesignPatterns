using System;

namespace EmailSender_Good
{
    public interface ILogger
    {
        void LogError(Exception exception);
    }
}