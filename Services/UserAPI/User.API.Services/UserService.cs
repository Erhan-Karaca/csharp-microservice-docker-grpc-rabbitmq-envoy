using System;
using System.Collections.Generic;
using System.Text;
using User.API.Infrastructure;
using User.API.Models;

namespace User.API.Services
{
    public class UserService : IUserService
    {
        public UserDTO GetUserById(int Id)
        {
            return new UserDTO()
            {
                Id = Id,
                FirstName = "Erhan",
                LastName = "KARACA"
            };
        }
    }
}
