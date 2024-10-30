using Front_To_Back_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace Front_To_Back_Project.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<RecentWork> RecentWorks { get; set; }
    public DbSet<Aim> Aims { get; set; }
    public DbSet<PricingPlan> PricingPlans { get; set; }
    public DbSet<ContactInfo> ContactInfos { get; set; }
}
