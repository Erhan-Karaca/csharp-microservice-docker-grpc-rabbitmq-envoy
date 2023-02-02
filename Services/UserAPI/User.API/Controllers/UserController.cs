using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.API.Infrastructure;
using User.API.Models;

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService UserService)
        {
            userService = UserService;
        }

        // GET api/<UserController>/5
        [HttpGet("{Id}")]
        public UserDTO Get(int Id)
        {
            return userService.GetUserById(Id);
        }
    }
}
