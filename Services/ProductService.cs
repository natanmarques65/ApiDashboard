using ApiDashboard.Model;
using ApiDashboard.Respository;

namespace ApiDashboard.Services
{
    public class ProductService
    {
        public async Task<List<Product>> GetAllProducts()
        {
            return await ProductRepository.FindAllProducts();
        }
    }
}
