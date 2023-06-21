using System.ComponentModel.DataAnnotations.Schema;
using contractFunds.Model.Enums;

namespace contractFunds.Model.Entities;

public class Creator
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string SurNameForCreator { get; set; }
    public string FirstNameForCreator { get; set; }
    public string UserNameForCreator { get; set; }
    public DateTime BirthDateForCreator { get; set; }
    public string EmailAddressForCreator { get; set; }
    public string PasswordForCreator { get; set; }
    public Roles Role { get; set; }
    public List<Project> Projects { get; set; }
    public string SolanaAddressForReceiveMoney { get; set; }
}