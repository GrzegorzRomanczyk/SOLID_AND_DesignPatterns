using System;

namespace PersonGenerator_Good
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person user = new Person();

            Console.WriteLine("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            user.LastName = Console.ReadLine();

            return user;
        }
    }
}