using ClienteAPI.Entity;
using ClienteAPI.Interfaces;
using ClienteAPI.Models;
using ClienteAPI.Models.Result;
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
        public IActionResult Create([FromBody]CreationUserRequest creationUserRequest)
        {
            try
            {
                _userService.CreateUser(creationUserRequest);
                return Ok(new Response() { Sucess = true, Data = null, Message = "Usuário criado com sucesso"});
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Get(int id)
        {
            try
            {
                User user = _userService.GetUser(id);
                return Ok(new Response() { Sucess = true, Data = user});
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        public IActionResult Update(UpdateUserRequest updateUserRequest)
        {
            try
            {
                _userService.UpdateUser(updateUserRequest);
                return Ok(new Response() { Sucess = true, Data = null, Message = "Usuário atualizado com sucesso" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

      
        [HttpDelete]
        [Route("[action]")]
        public IActionResult  Delete(int id)
        {
            try
            {
                _userService.DeleteUser(id);
                return Ok(new Response() { Sucess = true, Data = null, Message = "Usuário deletado com sucesso" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
