using ApiDashboard.Model;
using ApiDashboard.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiDashboard.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly SaleService _saleService;
        public SalesController(SaleService saleService)
        {
            _saleService = saleService;
        }

        public async Task<List<Sale>> GetAllSales()
        {
            return await _saleService.GetAllSales();
        }

    }
}
