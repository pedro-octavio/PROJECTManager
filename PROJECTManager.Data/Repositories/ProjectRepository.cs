using Microsoft.EntityFrameworkCore;
using PROJECTManager.Data.Interfaces;
using PROJECTManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJECTManager.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDataContext applicationDataContext;

        public ProjectRepository(ApplicationDataContext applicationDataContext)
        {
            this.applicationDataContext = applicationDataContext;
        }

        public async Task<IEnumerable<ProjectModel>> GetAllByCreateDateAsync(DateTime? startDate, DateTime? endDate)
        {
            var projects = new List<ProjectModel>();

            if (startDate != null && endDate != null)
            {
                projects = await applicationDataContext.Projects
                    .Where(x => x.CreateDate >= startDate && x.CreateDate <= endDate)
                    .ToListAsync();
            }
            else
            {
                projects = await applicationDataContext.Projects.ToListAsync();
            }

            projects = projects
                .OrderBy(x => x.CreateDate)
                .OrderBy(x => x.Name)
                .ToList();

            return projects;
        }

        public async Task<ProjectModel> GetByIdAsync(string id)
        {
            var project = await applicationDataContext.Projects.FindAsync(id);

            if (project != null)
            {
                applicationDataContext.Entry(project).State = EntityState.Detached;
            }

            return project;
        }

        public async Task AddAsync(ProjectModel projectModel)
        {
            await applicationDataContext.Projects.AddAsync(projectModel);

            await applicationDataContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(ProjectModel projectModel)
        {
            applicationDataContext.Projects.Update(projectModel);

            await applicationDataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(ProjectModel projectModel)
        {
            applicationDataContext.Projects.Remove(projectModel);

            await applicationDataContext.SaveChangesAsync();
        }
    }
}
