using System.ComponentModel.DataAnnotations;

namespace LOANMANAGEMENTAPI.Models
{
    public class Interest_Paid
    {
        [Key]
        public string FullName {get; set;}
        public string TotalPaid {get; set;}
        public string InterestPaid {get; set;}
        public string LoanID {get; set;}

    }
}