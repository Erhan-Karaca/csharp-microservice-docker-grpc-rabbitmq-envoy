using System;
using System.Collections.Generic;
using System.Text;
using User.API.Models;

namespace User.API.Infrastructure
{
    public interface IUserService
    {
        public UserDTO GetUserById(int Id);
    }
}
