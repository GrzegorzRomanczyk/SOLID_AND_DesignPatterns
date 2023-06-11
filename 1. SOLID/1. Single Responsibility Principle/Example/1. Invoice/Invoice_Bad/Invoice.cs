using System;
using System.Collections.Generic;

namespace Invoice_Bad
{
    public class Invoice
    {
        public Invoice(IEnumerable<LineItem> lineItems, string vendor, string vendee)
        {
            LineItems = lineItems;
            Vendor = vendor;
            Vendee = vendee;
            Total = this.CalculateTotal();
        }

        // 1 odpowiedzialnosc, agregacja danych
        public IEnumerable<LineItem> LineItems { get; set; }

        public float Total { get; set; }
        public string Vendee { get; set; }
        public string Vendor { get; set; }
        public float CalculateTotal()
        {
            float total = 0;
            foreach (var lineItem in LineItems)
            {
                total += lineItem.Price * lineItem.Count * (1 * lineItem.TaxRate);
            }

            return total;
        }

        // 2 odpowiedzialnosc, wyswietlenie faktury
        public void Display()
        {
            Console.WriteLine($"Vendor: {Vendor}");
            Console.WriteLine($"Vendee: {Vendee}");
            Console.WriteLine($"Total: {Total}");
        }

        // 3 odpowiedzialnosc, zapis do pliku pdf
        public void SaveToPdf()
        {
            Console.WriteLine("Saving to pdf");
        }
    }
}