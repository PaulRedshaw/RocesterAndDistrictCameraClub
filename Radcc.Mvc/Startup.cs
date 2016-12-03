using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using Radcc.Data.Context;
using Radcc.Model;

[assembly: OwinStartupAttribute(typeof(Radcc.Mvc.Startup))]
namespace Radcc.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesandUsers();


        }
        //Create default User roles and Admin user for login
        private void CreateRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            // Creating first Admin Role and creating a default Admin User   
            if (!roleManager.RoleExists("Admin"))  
            {  
                // Create Admin roll  
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();  
                role.Name = "Admin";  
                roleManager.Create(role);  
                // Create an Admin super user who will maintain the website                 

                        var user = new ApplicationUser();
                        user.UserName = "admin@rocesteranddistrictcamera.club";
                        user.FirstName = "Admin";
                        user.LastName = "RDCC";
                        user.EmailAddress = "admin@rocesteranddistrictcamera.club";

                        string userPWD = "Rdcc1234!";

                        var chkUser = userManager.Create(user, userPWD);
                        var adminRole = roleManager.FindByName("Admin");
                        //Add default User to Role Admin  
                        if (chkUser.Succeeded)
                        {
                            var result1 = userManager.AddToRole(user.Id, "Admin");

                        }  
               
            }  
     
            // creating Creating Member role   
            if (!roleManager.RoleExists("Member"))  
            {  
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();  
                role.Name = "Member";  
                roleManager.Create(role);  
    
            }  
    
            // creating Creating Chairman role   
            if (!roleManager.RoleExists("Chairman"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Chairman";
                roleManager.Create(role);

            }
            // creating Creating Secretary role   
            if (!roleManager.RoleExists("Secretary"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Secretary";
                roleManager.Create(role);

            }

            // creating Creating Programme Secretary role   
            if (!roleManager.RoleExists("Programme Secretary"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Programme Secretary";
                roleManager.Create(role);

            }

            // creating Creating Treasurer role   
            if (!roleManager.RoleExists("Treasurer"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Treasurer";
                roleManager.Create(role);

            }
            // creating Creating Committee Member role   
            if (!roleManager.RoleExists("Committee Member"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Committee Member";
                roleManager.Create(role);

            }

            // creating Creating Webmaster role   
            if (!roleManager.RoleExists("Webmaster"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Webmaster";
                roleManager.Create(role);

            }

            if (!roleManager.RoleExists("Publicity Officer"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Publicity Officer";
                roleManager.Create(role);

            }
           

        }
    }
}
