using contractFunds.Model.DTOs;
using contractFunds.Model.Entities;

namespace contractFunds.Service;

public interface IDonationService
{
    Task<bool> CreateDonation(DonationDTO donationDto);
    Task<List<Donation>> GetAllDonationsForBacker(long backerId);
    Task<List<Donation>> GetAllDonationsForProject(long projectId);
    Task DonateProject();
}