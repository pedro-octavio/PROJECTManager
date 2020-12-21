using Microsoft.EntityFrameworkCore;
using PROJECTManager.Data.Models;

namespace PROJECTManager.Data.Configuration.Tables
{
    public static class ProjectTable
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectModel>()
                .Property(x => x.Id)
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<ProjectModel>()
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<ProjectModel>()
                .Property(x => x.Description)
                .HasMaxLength(4200);

            modelBuilder.Entity<ProjectModel>()
                .Property(x => x.CreateDate)
                .IsRequired();
        }
    }
}
