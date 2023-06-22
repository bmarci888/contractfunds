using System.ComponentModel.DataAnnotations.Schema;
using contractFunds.Model.Enums;

namespace contractFunds.Model.Entities;

public class Backer
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string SurNameForBacker { get; set; }
    public string FirstNameForBacker { get; set; }
    public string UserNameForBacker { get; set; }
    public DateTime BirthDateForBacker { get; set; }
    public string EmailAddressForBacker { get; set; }
    public string PasswordForBacker { get; set; }
    public Roles Role { get; set; }
    public List<Project> FavouriteProjects { get; set; }
    public List<Donation> Donations { get; set; }
    public string SolanaAddressForRefund { get; set; }
}