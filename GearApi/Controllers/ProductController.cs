using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GearApi.Controllers
{
    public class ProductController : GenericController<ProductModel, ProductRepository>
    {
        [HttpGet("GetByCategory/{categoryId}")]
        public List<ProductModel> GetByCategory(int categoryId)
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.GetByCategory(categoryId);
        }
    }
}
