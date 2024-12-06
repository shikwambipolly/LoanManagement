using System.ComponentModel.DataAnnotations;

namespace LOANMANAGEMENTAPI.Models
{
    public class Outstanding_Amount
    {
        [Key]
        public string LoanID {get; set;}
        public float LoanAmount {get; set;}
        public float Paid {get; set;}
        public float Outstanding {get; set;}

    }
}