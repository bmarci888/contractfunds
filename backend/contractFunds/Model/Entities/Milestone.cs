using System.ComponentModel.DataAnnotations.Schema;

namespace contractFunds.Model.Entities;

public class Milestone
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string MilestoneTitle { get; set; }
    public string MilestoneDescription { get; set; }
    public DateTime MilestoneCreationDate { get; set; }
    public DateTime MilestoneDeadline { get; set; }
    public Project ProjectOfMilestone { get; set; }
    public double MoneyToUnlock { get; set; }
}