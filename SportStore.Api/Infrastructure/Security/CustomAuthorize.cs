using SportStore.Api.Services;
using SportStore.Api.ViewModels;
using SportStore.Repository.ISportStoreRepo;
using SportStore.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SportStore.Api.Infrastructure.Security
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class CustomAuthorize : AuthorizeAttribute
    {
        public string UserRole { get; set; }
        public  IAccountService _account { get; set; }

        public CustomAuthorize(params  string[] roles) : base()
        {
            this.Roles = string.Join(",", roles);
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var isAuthorized = base.AuthorizeCore(httpContext);
            if(!isAuthorized)
            {
                return false;
            }
            string currentUser = httpContext.User.Identity.Name.ToString();
            var currentUserRole = _account.GetCustomUserRoleAsync(currentUser).Result;

            if(this.UserRole.Contains(currentUserRole))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

 
}