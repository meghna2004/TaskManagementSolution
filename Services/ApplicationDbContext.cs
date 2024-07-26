using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManagementSolution.Models;
namespace TaskManagementSolution.Services
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var userRole = new IdentityRole("basicuser");
            userRole.NormalizedName = "BasicUser";

            var adminRole = new IdentityRole("admin");
            adminRole.NormalizedName = "Admin";
            var managerRole = new IdentityRole("teammanager");
            managerRole.NormalizedName = "TeamManager";
            modelBuilder.Entity<IdentityRole>().HasData(userRole, adminRole, managerRole);
        }
    }
}
