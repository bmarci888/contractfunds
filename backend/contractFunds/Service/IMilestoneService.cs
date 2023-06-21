using contractFunds.Model.DTOs;
using contractFunds.Model.Entities;

namespace contractFunds.Service;

public interface IMilestoneService
{
    Task<bool> CreateMilestone(MilestoneDTO milestoneDto);
    Task<List<Milestone>> GetAllMilestonesForActualProject(long projectId);
}