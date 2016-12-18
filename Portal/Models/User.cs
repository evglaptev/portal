using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal.Models
{

    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public ContextUser ContextUser { get; set; }
        public int? ContextUserId { get; set; }
        public User()
        {
            RoleId = 1;
        }
    }

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}