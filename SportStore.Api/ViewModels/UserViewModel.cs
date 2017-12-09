using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Api.ViewModels
{
    public class UserViewModel
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Code { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}