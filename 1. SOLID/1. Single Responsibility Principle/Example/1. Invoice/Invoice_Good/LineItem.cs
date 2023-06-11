namespace Invoice_Good
{
    public class LineItem
    {
        public int Count { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int TaxRate { get; set; }
    }
}