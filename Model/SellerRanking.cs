namespace ApiDashboard.Model
{
    public class SellerRanking
    {
        public Seller Seller { get; set; }
        public int RankingPosition { get; set; }
        public decimal TotalSales { get; set; }
        public int TotalSalesAmount { get; set; }
    }
}
