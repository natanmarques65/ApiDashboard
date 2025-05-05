using ApiDashboard.Model;
using ApiDashboard.Respository;

namespace ApiDashboard.Services
{
    public class SellerService
    {
        private readonly SaleRepository _saleRepository;

        public SellerService(SaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        public async Task<List<Seller>> GetAllSellers()
        {
            return await SellersRepository.FindAllSellers();
        }

        public async Task<List<SellerRanking>> GetSellerRanking(int maxSellerPosition)
        {
            var sales = new List<Sale>();
            sales = await _saleRepository.FindAllSales();

            if (!sales.Any()) { throw new Exception("Sales not found"); }
            var sallers = from saller in sales
                          group saller by saller.Seller.Id into s
                          orderby s.Key
                          select s;

            var ranking = new List<SellerRanking>();

            foreach (var s in sallers)
            {
                var seller = new SellerRanking();
                seller.Seller = s.FirstOrDefault().Seller ?? new Seller();
                seller.TotalSales = s.Count();
                seller.TotalSalesAmount = s.Sum(s => s.Items.Sum(i => i.Product.Price * i.Quantity));

                ranking.Add(seller);
            }

            ranking = ranking.OrderByDescending(ranking => ranking.TotalSalesAmount).ToList();

            return ranking;
        }

    }
}
