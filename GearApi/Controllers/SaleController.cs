using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GearApi.Controllers
{
    public class SaleController : GenericController<SaleModel, SaleRepository>
    {
        public SaleController() : base(new SaleRepository())
        {
        }
    }
}
