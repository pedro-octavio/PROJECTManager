using PROJECTManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROJECTManager.Data.Interfaces
{
    public interface IProjectRepository
    {
        Task<IEnumerable<ProjectModel>> GetAllByCreateDateAsync(DateTime? startDate, DateTime? endDate);
        Task<ProjectModel> GetByIdAsync(string id);
        Task AddAsync(ProjectModel projectModel);
        Task UpdateAsync(ProjectModel projectModel);
        Task DeleteAsync(ProjectModel projectModel);
    }
}
