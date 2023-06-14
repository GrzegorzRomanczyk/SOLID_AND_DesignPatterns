using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonGenerator_Bad
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. wyswietlanie standardowych wiadomosci
            Console.WriteLine("Welcome to my app");
            
            Person user = new Person();

            //2. pobieranie danych od uzytkownika
            Console.WriteLine("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            user.LastName = Console.ReadLine();

            //3. sprawdzenie czy uzytkownik podal odpowiednie dane
            if(string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("Wrong first name");
                Console.ReadLine();
                return;
            }

            if(string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("Wrong last name");
                Console.ReadLine();
                return;
            }

            //4. generowanie nowego uzytkownika
            Console.WriteLine($"Your username is { user.FirstName.Substring(0, 1) }{ user.LastName}");

            Console.ReadLine();
        }
    }
}
