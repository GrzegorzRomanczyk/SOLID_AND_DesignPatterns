using System;

namespace Invoice_Good
{
    public class InvoicePersistance
    {
        private Invoice invoice;

        public InvoicePersistance(Invoice invoice)
        {
            this.invoice = invoice;
        }

        public void SaveToPdf()
        {
            Console.WriteLine("Saving to pdf");
        }
    }
}