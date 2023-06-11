using System;
using System.Collections.Generic;

namespace Invoice_Good
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IEnumerable<LineItem> items = new List<LineItem>()
            {
                new LineItem()
                {
                    Name = "Banan",
                    Price = 10,
                    TaxRate = 13,
                    Count = 1
                },
                new LineItem()
                {
                    Name = "Mandarynka",
                    Price = 6,
                    TaxRate = 13,
                    Count = 5
                }
            };

            Invoice invoice = new Invoice(items, "Ihor", "Grzesiek");

            InvoiceLogger logger = new InvoiceLogger(invoice);
            logger.Display();

            InvoicePersistance persistance = new InvoicePersistance(invoice);
            persistance.SaveToPdf();

            Console.ReadKey();
        }
    }
}