using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationPlatform.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EducationPlatform.Infrastructure.Persistence.Context;
public class EducationPlatformDbContext : DbContext
{
    public EducationPlatformDbContext(DbContextOptions<EducationPlatformDbContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
    public DbSet<SubscriptionPlanUser> SubscriptionPlanUsers { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Module> Modules { get; set; }
    public DbSet<Tutorial> Tutorials { get; set; }
    public DbSet<TutorialCompletedUser> TutorialCompletedUsers { get; set; }
}
