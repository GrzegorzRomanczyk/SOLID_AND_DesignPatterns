using System;

namespace PersonGenerator_Good
{
    public class StandardMessages
    {
        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"Wrong {fieldName}");
        }

        public static void EndApp()
        {
            Console.ReadLine();
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my app");
        }
    }
}