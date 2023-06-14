namespace EmailSender_Good
{
    public interface IStatistics
    {
        void AddToStats(IEmailSender emailSender);
    }
}
