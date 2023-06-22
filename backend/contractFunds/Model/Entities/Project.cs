using System.ComponentModel.DataAnnotations.Schema;
using contractFunds.Model.Enums;

namespace contractFunds.Model.Entities;

public class Project
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string ProjectName { get; set; }
    public string ProjectDescriptionShort { get; set; }
    public string ProjectDescriptionLong { get; set; }
    public string TeamDescription { get; set; }
    public string ProjectLocation { get; set; }
    public string Photos { get; set; }
    public string Videos { get; set; }
    public Categories Category { get; set; }
    public double RequestedAmountOfMoney { get; set; }
    public double GatheredMoney { get; set; }
    public List<Milestone> Milestones { get; set; }
    public DateTime ProjectCreationDate { get; set; }
    public DateTime ProjectDeadline { get; set; }
    public Creator ProjectCreator { get; set; }
    public List<Donation> Donations { get; set; }
    public List<Backer> ProjectBackers { get; set; }
}