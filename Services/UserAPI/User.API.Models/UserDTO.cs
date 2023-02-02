using System;
using System.Collections.Generic;
using System.Text;

namespace User.API.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String FullName => $"{FirstName} {LastName}"; 
    }
}
