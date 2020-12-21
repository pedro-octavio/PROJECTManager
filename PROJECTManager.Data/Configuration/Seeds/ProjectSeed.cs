using Microsoft.EntityFrameworkCore;
using PROJECTManager.Data.Models;
using System;

namespace PROJECTManager.Data.Configuration.Seeds
{
    public class ProjectSeed
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectModel>()
                .HasData(
                new ProjectModel
                {
                    Id = "p02bz8aql1",
                    Name = "HR System",
                    Description = "A System of control collaborators.",
                    CreateDate = DateTime.ParseExact("08/07/2017", "MM/dd/yyyy", null)
                },
                new ProjectModel
                {
                    Id = "a02mxlzp1a",
                    Name = "Storage System Project",
                    Description = "Legacy system.",
                    CreateDate = DateTime.ParseExact("04/13/2019", "MM/dd/yyyy", null)
                },
                new ProjectModel
                {
                    Id = "ms910alqx7",
                    Name = "Rules Implementation in Bank Client",
                    Description = string.Empty,
                    CreateDate = DateTime.ParseExact("02/17/2020", "MM/dd/yyyy", null)
                }
                );
        }
    }
}
