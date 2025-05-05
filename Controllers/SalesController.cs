using ApiDashboard.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiDashboard.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {

        public Task<List<Sale>> GetAllSales()
        {
            return Task.FromResult(new List<Sale>());
        }

    }
}
