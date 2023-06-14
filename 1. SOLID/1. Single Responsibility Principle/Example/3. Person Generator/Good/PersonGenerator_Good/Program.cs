namespace PersonGenerator_Good
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);
            if (!isUserValid)
            {
                StandardMessages.EndApp();
                return;
            }

            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApp();
        }
    }
}