using Data.Model;
using Data.Repository;
using GearApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GearApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessController : ControllerBase
    {
        [HttpPost("Logon")]
        public UserModel Logon(UserDto userDto)
        {
            UserRepository userRepository = new UserRepository();
            UserModel entity = userRepository.Logon(userDto.Email, userDto.Password);
            return entity;
        }
    }
}
