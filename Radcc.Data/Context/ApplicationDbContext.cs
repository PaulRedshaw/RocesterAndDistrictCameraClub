using Microsoft.AspNet.Identity.EntityFramework;
using Radcc.Model;
using Radcc.Mvc.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Radcc.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("RadccDataConnection") { }

        public DbSet<Programme> Programmes { get; set; }
        public DbSet<UsefulLink> UsefulLinks { get; set; }
        public DbSet<NewsArticle> NewsArticles { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new IdentityUserLoginConfiguration());
            modelBuilder.Configurations.Add(new IdentityUserRoleConfiguration());
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

    internal class IdentityUserRoleConfiguration : EntityTypeConfiguration<IdentityUserRole>
    {
        public IdentityUserRoleConfiguration()
        {
            HasKey(iur => iur.RoleId);
        }

    }

    internal class IdentityUserLoginConfiguration : EntityTypeConfiguration<IdentityUserLogin>
    {
        public IdentityUserLoginConfiguration()
        {
            HasKey(iul => iul.UserId);
        }
    }
}
