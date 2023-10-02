using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RMA.Models;

namespace RMA.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext()
        {
        }
        //Calling IdentityDbContext base class constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Role> Role { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Issue> Issue { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Stats> Stats { get; set; }

        //Look-Ups
        public DbSet<IssueStatus> IssueStatus { get; set; }
        public DbSet<ApprovalStatus> ApprovalStatus { get; set; }
        public DbSet<IssueType> IssueType { get; set; }
        public DbSet<Hazard> Hazard { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);


        }

    }
}
