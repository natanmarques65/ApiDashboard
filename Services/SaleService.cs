using ApiDashboard.Model;
using ApiDashboard.Respository;

namespace ApiDashboard.Services
{
    public class SaleService
    {
        public readonly SaleRepository _saleRepository;
        public SaleService(SaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }
        public async Task<List<Sale>> GetAllSales()
        {
            return await _saleRepository.FindAllSales();
        }
    }
}
