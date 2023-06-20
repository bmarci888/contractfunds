using System.ComponentModel.DataAnnotations.Schema;

namespace contractFunds.Model.Entities;

public class Voting
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public Project ProjectToVote { get; set; }
    public DateTime StartOfVoting { get; set; }
    public DateTime EndOfVoting { get; set; }
    public Milestone MilestoneToVote { get; set; }
    public int TrustVote { get; set; }
    public int TrustlessVote { get; set; }
}