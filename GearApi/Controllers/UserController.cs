using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GearApi.Controllers
{
    public class UserController : GenericController<UserModel, UserRepository>
    {
        public UserController() : base(new UserRepository())
        {
        }
    }
}
