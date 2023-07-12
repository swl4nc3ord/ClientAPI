using ClienteAPI.Entity;
using ClienteAPI.Interfaces;
using ClienteAPI.Models;
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
        public ActionResult Create(CreationUserRequest creationUserRequest)
        {
            try
            {
                _userService.CreateUser(creationUserRequest);
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
                User user = _userService.GetUser(id);
                return Ok(user);
            }
            catch
            {
                return View();
            }
        }

        [HttpPut]
        [Route("[action]")]
        public ActionResult Update(UpdateUserRequest updateUserRequest)
        {
            try
            {
                _userService.UpdateUser(updateUserRequest);
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
                _userService.DeleteUser(id);
                return Ok();
            }
            catch
            {
                return View();
            }
        }
    }
}
