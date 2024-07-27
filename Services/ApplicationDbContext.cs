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
        public DbSet<Address> Address { get; set; }
        public DbSet<CustomerSupport> CustomerSupport { get; set; }
        public DbSet<TaskList> TaskList { get; set; }
        public DbSet<TaskManager> TaskManager { get; set; }
        public DbSet<Tasks> Task { get; set; }
        public DbSet<TaskUser> TaskUser { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<TeamMember> TeamMember { get; set; }
        public DbSet<UserAddress> UserAddress { get; set; }
        

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
