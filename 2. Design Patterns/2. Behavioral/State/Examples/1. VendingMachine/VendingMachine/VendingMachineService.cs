using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachineService
    {
        public const int EMPTY = 0;
        public const int NO_COIN = 1;
        public const int WITH_COIN = 2;
        public const int SOLD = 3;
        private int currentState = EMPTY;
        private int productCounter = 0;

        public VendingMachineService(int productCounter)
        {
            this.productCounter = productCounter;
            if (productCounter > 0)
            {
                currentState = NO_COIN;
            }
        }

        public void InsertCoin()
        {
            if (currentState == WITH_COIN)
            {
                Console.WriteLine("Nie można włożyć wiecej niz jednej monety");
            }
            else if (currentState == NO_COIN)
            {
                currentState = WITH_COIN;
                Console.WriteLine("Moneta przyjęta");
            }
            else if (currentState == EMPTY)
            {
                Console.WriteLine("Nie można włożyć monety gdy automat jest pusty");
            }
            else if (currentState == SOLD)
            {
                Console.WriteLine("Proszę czekać na wydanie produktu");
            }
        }

        public void ReturnCoin()
        {
            if (currentState == WITH_COIN)
            {
                Console.WriteLine("Moneta zwrocona");
                currentState = NO_COIN;
            }
            else if (currentState == NO_COIN)
            {
                Console.WriteLine("Nie włożyłeś monety");
            }
            else if (currentState == SOLD)
            {
                Console.WriteLine("Niestety nie można zwrócić monety po zatwierdzeniu zakupu");
            }
            else if (currentState == EMPTY)
            {
                Console.WriteLine("Nie włożyłeś monety");
            }
        }

        public void ApprovePurchase()
        {
            if (currentState == SOLD)
            {
                Console.WriteLine("Nie dostaniesz produktu tylko dlatego, że potwierdzileś drugi raz");
            }
            else if (currentState == NO_COIN)
            {
                Console.WriteLine("Zanim zatwierdzisz zakup należy wrzucić monete");
            }
            else if (currentState == EMPTY)
            {
                Console.WriteLine("Zatwierdziłeś zakup, ale automat jest pusty");
            }
            else if (currentState == WITH_COIN)
            {
                Console.WriteLine("Zatwierdzono zakup");
                currentState = SOLD;
                DeliverProduct();
            }
        }

        private void DeliverProduct()
        {
            if (currentState == SOLD)
            {
                Console.WriteLine("Produkt wypada");
                productCounter -= 1;
                if(productCounter == 0)
                {
                    Console.WriteLine("Ups, brak produktu w automacie");
                    currentState = EMPTY;
                }
                else
                {
                    currentState = NO_COIN;
                }
                
            }
            // Ponizsze sytuacje nie powinny miec miejsca ale lepiej sie zabezieczyc i rzucic informacje niz wydac produkt
            else if (currentState == NO_COIN)
            {
                Console.WriteLine("Najpierw zaplac");
            }
            else if (currentState == EMPTY)
            {
                Console.WriteLine("Nie wydano produktu, z powodu braku towaru");
            }
            else if (currentState == WITH_COIN)
            {
                Console.WriteLine("Nie wydano produktu");
            }
        }

        public override string ToString()
        {
            string currentStateString = "Brak produktow";

            if (currentState == WITH_COIN)
            {
                currentStateString = "Wrzucono monete";
            }
            else if (currentState == NO_COIN)
            {
                currentStateString = "Brak monety";
            }
            else if (currentState == EMPTY)
            {
                currentStateString = "Brak produktow"; ;
            }
            else if (currentState == SOLD)
            {
                currentStateString = "Produkt sprzedany, oczekuj na wydanie"; 
            }

            return $"\nAutomat do sprzedaży produktów.\nZapas produktów: {productCounter}.\nObecny stan {currentStateString}\n";
        }
    }
}
