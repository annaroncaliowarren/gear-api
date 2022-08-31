using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GearApi.Controllers
{
    public class AddressController : GenericController<AddressModel, AddressRepository>
    {
        public AddressController() : base(new AddressRepository())
        {
        }
    }
}
