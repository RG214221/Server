using Microsoft.AspNetCore.Mvc;
using Server.Repository.Entities;
using Services.Interfaces;
using Services.Models;
using Services.ServiceClasses;

namespace Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        public UserController(IUserService service)
        {
            _userService = service;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<IEnumerable<UserModel>> Get()
        {
            var result = await _userService.GetAllAsync();
            return result;
        }

        // GET api/<UsersController>/id
        [HttpGet("{id}")]
        public async Task<UserModel> GetByIdNumber(string id)
        {
            return await  _userService.GetByIdNumberAsync(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<UserModel?> Post([FromBody] UserModel user)
        {
            if(GetByIdNumber(user.UserIDNumber).Result!=null)
                return null;
            return await _userService.AddAsync(user);
            
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public async Task<UserModel> Put([FromBody] UserModel user)
        {
            return await _userService.UpdateAsync(user);
        }
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _userService.DeleteAsync(id);
        }
    }
}
