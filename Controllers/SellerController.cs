using ApiDashboard.Model;
using ApiDashboard.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiDashboard.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {

        private readonly SellerService _sellerService;
        public SellerController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        [HttpGet("")]
        public async Task<ActionResult<List<Seller>>> GetAllSellers()
        {
            var sellers = await _sellerService.GetAllSellers();
            return sellers;
        }

        [HttpGet("ranking")]
        public async Task<ActionResult<List<SellerRanking>>> GetSellerRanking([FromQuery] int maxSeller)
        {
            return await _sellerService.GetSellerRanking(maxSeller);
        }
    }
}
