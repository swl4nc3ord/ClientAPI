using ClienteAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClienteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("[action]")]
        public ActionResult Create()
        {
            try
            {
                return Ok();
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult Get(int id)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return View();
            }
        }

        [HttpPut]
        [Route("[action]")]
        public ActionResult Edit(int id)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return View();
            }
        }

      
        [HttpDelete]
        [Route("[action]")]
        public ActionResult Delete(int id)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return View();
            }
        }
    }
}
