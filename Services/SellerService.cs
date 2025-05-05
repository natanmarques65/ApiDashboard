using ApiDashboard.Model;
using ApiDashboard.Respository;

namespace ApiDashboard.Services
{
    public class SellerService
    {
        public async Task<List<Seller>> GetAllSellers()
        {
            return await SellersRepository.FindAllSellers();
        }
    }
}
