namespace client
{
    public class Product
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        //public decimal Supplier_Price { get; set; }
        public decimal Retail_Price { get; set; }
        public decimal Weight { get; set; }
        public int Quantity { get; set; } = 0;
    }
}