using System.ComponentModel.DataAnnotations.Schema;

namespace contractFunds.Model.DTOs;

public class DonationDTO
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public long DonatorId { get; set; }
    public double DonatedAmountOfMoney { get; set; }
    public DateTime DonationDate { get; set; }
    public long DonatedProjectId { get; set; }
}