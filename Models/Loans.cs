using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOANMANAGEMENTAPI.Models
{
    public class Loans
    {
        [Key]
        [Required]
        [MaxLength(36)] // Matches VARCHAR(36) in SQL
        public string LoanID { get; set; }

        [Required]
        [MaxLength(36)] // Matches VARCHAR(36) in SQL
        public string BorrowerID { get; set; }

        [Required]
        [Column(TypeName = "decimal(15, 2)")]
        public decimal LoanAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal InterestRate { get; set; }

        [Required]
        public int LoanTermMonths { get; set; }

        [Required]
        public DateTime LoanStartDate { get; set; }

        public DateTime? LoanEndDate { get; set; }

        [Required]
        [MaxLength(20)] // Matches NVARCHAR(20) in SQL
        public string Status { get; set; }
    }
}
