using contractFunds.Model.DTOs;
using contractFunds.Model.Entities;

namespace contractFunds.Service;

public interface ICreatorService
{
    Task<bool> CreateCreator(CreatorDTO creatorDto);
    Task<bool> DeleteCreator(long creatorId);
    Task<bool> UpdateCreator(CreatorDTO creatorDto);
    Task<Creator> GetActualCreator(long creatorId);
}