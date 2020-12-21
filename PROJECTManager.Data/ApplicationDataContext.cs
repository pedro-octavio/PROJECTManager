using Microsoft.EntityFrameworkCore;
using PROJECTManager.Data.Configuration.Seeds;
using PROJECTManager.Data.Configuration.Tables;
using PROJECTManager.Data.Models;

namespace PROJECTManager.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ProjectTable.Configure(modelBuilder);
            ProjectSeed.Configure(modelBuilder);
        }

        public DbSet<ProjectModel> Projects { get; set; }
    }
}
