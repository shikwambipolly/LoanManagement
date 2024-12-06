using System.ComponentModel.DataAnnotations;

namespace LOANMANAGEMENTAPI.Models
{
    public class Borrowers
    {
        [Key]
        public string BorrowerID {get; set;}
        public string FullName {get; set;}
        public string Email {get; set;}
        public string PhoneNumber {get; set;}

        public string Address {get; set;}

    }
}