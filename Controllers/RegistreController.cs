using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserRegistration.Models;

namespace UserRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistreController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UserModel>> GetAllUsers()
        {
            return Ok();
        }
    }
}
