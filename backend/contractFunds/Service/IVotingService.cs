using contractFunds.Model.DTOs;
using contractFunds.Model.Entities;

namespace contractFunds.Service;

public interface IVotingService
{
   Task<bool> CreateVoting(VotingDTO votingDto);
   Task<List<Voting>> GetAllVotingsForProject(long projectId);
   Task<Voting> GetVotingForMilestone(long milestoneId);
   Task<bool> UpdateVoting(long votingId, bool trust);
   Task SendMoneyToCreator();
   Task RefundMoneyToBackers();
}