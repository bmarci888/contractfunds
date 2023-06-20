using System.ComponentModel.DataAnnotations.Schema;

namespace contractFunds.Model.Entities;

public class Donation
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public Backer Donator { get; set; }
    public double DonatedAmountOfMoney { get; set; }
    public DateTime DonationDate { get; set; }
    public Project DonatedProject { get; set; }
}