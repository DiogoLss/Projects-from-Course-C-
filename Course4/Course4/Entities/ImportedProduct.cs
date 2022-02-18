namespace Course4.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public override string PriceTag()
        {
            return $"{Name} ${TotalPrice()} (Customs fee: ${CustomsFee})";
        }
        public double TotalPrice()
        {
            return CustomsFee + Price;
        }
    }
}
