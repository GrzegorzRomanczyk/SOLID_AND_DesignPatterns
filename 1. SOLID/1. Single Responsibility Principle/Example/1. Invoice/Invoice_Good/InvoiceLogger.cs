using System;

namespace Invoice_Good
{
    public class InvoiceLogger
    {
        private Invoice invoice;

        public InvoiceLogger(Invoice invoice)
        {
            this.invoice = invoice;
        }

        public void Display()
        {
            Console.WriteLine($"Vendor: {invoice.Vendor}");
            Console.WriteLine($"Vendee: {invoice.Vendee}");
            Console.WriteLine($"Total: {invoice.Total}");
        }
    }
}