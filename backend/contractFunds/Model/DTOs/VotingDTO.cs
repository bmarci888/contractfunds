using System.ComponentModel.DataAnnotations.Schema;

namespace contractFunds.Model.DTOs;

public class VotingDTO
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public long ProjectIdToVote { get; set; }
    public DateTime StartOfVoting { get; set; }
    public DateTime EndOfVoting { get; set; }
    public long MilestoneIdToVote { get; set; }
    public int TrustVote { get; set; }
    public int TrustlessVote { get; set; }
}