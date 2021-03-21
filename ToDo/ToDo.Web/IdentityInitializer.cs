using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Entities.Concrete;

namespace ToDo.Web
{
    public static class IdentityInitializer
    {
        public static async System.Threading.Tasks.Task SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Admin" });
            }
            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Member" });
            }
            var adminUser = await userManager.FindByNameAsync("admin");
            if (adminUser == null)
            {
                AppUser user = new AppUser
                {
                    Name = "Admin",
                    Surname = "Admin",
                    UserName = "admin",
                    Email = "admin@gmail.com"
                };
                await userManager.CreateAsync(user, "123");
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
