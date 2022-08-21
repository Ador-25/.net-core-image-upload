using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace image_upload_api.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetUsers()
        {
            return Ok("All users");
        }
        [HttpPost]
        [Route("api/[controller]/addUser")]
        public IActionResult AddUser()
        {
            return Ok("All users");
        }

    }
}
