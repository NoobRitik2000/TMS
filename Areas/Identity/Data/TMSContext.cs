using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Task_Management.Models;
using TMS.Areas.Identity.Data;

namespace TMS.Areas.Identity.Data;

public class TMSContext : IdentityDbContext<AppUser>
{
    public TMSContext(DbContextOptions<TMSContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    // DbSet properties
    //public DbSet<User> Users { get; set; }
    //public DbSet<Role> Roles { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Files> Files { get; set; }
    public DbSet<Reports> Reports { get; set; }
    public DbSet<ProjectMember> ProjectMember { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Reminder> Reminder { get; set; }
    public DbSet<Notifications> Notifications { get; set; }
    public DbSet<Calender> Calenders { get; set; }
    public DbSet<Activities> Activities { get; set; }
    public DbSet<MyTask> MyTasks { get; set; }
}
