using contractFunds.Model.DTOs;
using contractFunds.Model.Entities;

namespace contractFunds.Service;

public interface IBackerService
{
    Task<bool> AddToFavourite(long projectId, long backerId);
    Task<bool> RemoveFromFavourite(long projectId, long backerId);
    Task<bool> CreateBacker(BackerDTO backerDto);
    Task<bool> UpdateBacker(BackerDTO backerDto);
    Task<bool> DeleteBacker(long backerId);
    Task<Backer> GetActualBacker(long backerId);
}