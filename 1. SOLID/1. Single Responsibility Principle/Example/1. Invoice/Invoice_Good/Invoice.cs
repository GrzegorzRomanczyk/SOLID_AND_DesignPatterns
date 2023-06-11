using System.Collections.Generic;

namespace Invoice_Good
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
    }
}