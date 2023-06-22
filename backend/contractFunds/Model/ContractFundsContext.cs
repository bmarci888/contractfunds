using contractFunds.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace contractFunds.Model;

public class ContractFundsContext : DbContext
{
    public ContractFundsContext(DbContextOptions<ContractFundsContext> options) : base(options)
    {
    }
    
    public DbSet<Backer> Backers { get; set; }
    public DbSet<Creator> Creators { get; set; }
    public DbSet<Donation> Donations { get; set; }
    public DbSet<Milestone> Milestones { get; set; }
    public DbSet<Project> Projects{ get; set; }
    public DbSet<Voting> Votings { get; set; }
}