namespace ApiDashboard.Model
{
    public class Sale
    {
        public Seller Seller { get; set; }
        public Guid Id { get; set; }
        public List<SaleItem> Items { get; set; }
    }
}
