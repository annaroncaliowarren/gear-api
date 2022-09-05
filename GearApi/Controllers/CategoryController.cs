using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GearApi.Controllers
{
    public class CategoryController : GenericController<CategoryModel, CategoryRepository>
    {
        [HttpGet("User/{id}")]
        public List<CategoryModel> GetByUserId(int id)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            return categoryRepository.GetByUserId(id);
        }
    }
}
