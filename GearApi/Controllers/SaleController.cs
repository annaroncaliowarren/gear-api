using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GearApi.Controllers
{
    public class SaleController : GenericController<SaleModel, SaleRepository>
    {
        [HttpGet("User/{id}")]
        public List<SaleModel> GetByUserId(int id)
        {
            SaleRepository saleRepository = new SaleRepository();
            return saleRepository.GetByUserId(id);
        }
    }
}
