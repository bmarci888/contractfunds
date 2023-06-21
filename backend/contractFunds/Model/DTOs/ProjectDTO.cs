using System.ComponentModel.DataAnnotations.Schema;
using contractFunds.Model.Enums;

namespace contractFunds.Model.DTOs;

public class ProjectDTO
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
    public DateTime ProjectCreationDate { get; set; }
    public DateTime ProjectDeadline { get; set; }
    public int ProjectCreatorId { get; set; }
}