using System;

namespace EmailSender_Good
{
    internal class Program
    {
        private IEmailSender emailSender;
        private ILogger logger;
        private IStatistics statistics;

        public Program(IEmailSender emailSender, ILogger logger, IStatistics statistics)
        {
            this.emailSender = emailSender;
            this.logger = logger;
            this.statistics = statistics;
        }

        public void SendEmail()
        {
            try
            {
                emailSender.Send();
                statistics.AddToStats(emailSender);
            }
            catch (Exception exception)
            {
                logger.LogError(exception);
                throw;
            }
        }

        private static void Main(string[] args)
        {
            IEmailSender emailSender = new EmailSender();
            ILogger logger = new Logger();
            IStatistics statistics = new Statistics();

            Program program = new Program(emailSender, logger, statistics);
            program.SendEmail();

            Console.ReadKey();
        }
    }
}