using contractFunds.Model.DTOs;
using contractFunds.Model.Entities;

namespace contractFunds.Service;

public interface IProjectService
{
    Task<bool> CreateProject(ProjectDTO projectDto);
    Task<bool> UpdateProject(ProjectDTO projectDto);
    Task<bool> DeleteProject(long projectId);
    Task<List<Project>> GetAllProjects();
    Task<Project> GetActualProject(long projectId);
}