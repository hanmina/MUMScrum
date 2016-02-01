using MUMScrum.Entity;
using System.Data.Entity;

namespace MUMScrum.DAL
{
    public class MUMScrumDbContext : DbContext
    {
        
        public MUMScrumDbContext() : base("DefaultConnection")
        {
        }

        public static MUMScrumDbContext Create()
        {
            return new MUMScrumDbContext();
        }

        public DbSet<ProductBacklog> ProductBacklogs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ReleaseBacklog> ReleaseBacklogs { get; set; }
        public DbSet<Sprint> Sprints { get; set; }

        public System.Data.Entity.DbSet<MUMScrum.Entity.UserStory> UserStories { get; set; }
        public System.Data.Entity.DbSet<MUMScrum.Entity.UserStoryLog> UserStoryLogs { get; set; }

    }
}
