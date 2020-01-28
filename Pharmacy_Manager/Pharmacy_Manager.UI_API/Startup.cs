using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Pharmacy_Manager.UI_API.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

[assembly: OwinStartup(typeof(Pharmacy_Manager.UI_API.Startup))]

namespace Pharmacy_Manager.UI_API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateUserRole();
        }

        public void CreateUserRole()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if(!roleManager.RoleExists("SuperAdmin"))
            {
                //create the initial role
                var role = new IdentityRole("SuperAdmin");
                roleManager.Create(role);


                //create the initial user
                var user = new ApplicationUser();
                user.Email = "chuks4ken@gmail.com";
                user.UserName = "chuks4ken@gmail.com";
                user.FullName = "Chukwuka";
                user.ContactNo = "07031122227";
                string pwd = "Passw0rd@123";
               var newUser = userManager.Create(user, pwd);

                if(newUser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "SuperAdmin");
                }

            }
        }
    }
}
