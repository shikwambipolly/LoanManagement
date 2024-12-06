using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOANMANAGEMENTAPI.Models
{
    public class History
    {
        [Key]
        public string PaymentID { get; set; }

        [Required]
        public string LoanID { get; set; }

        [Required]
        public string BorrowersID { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal LoanAmount { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal PaymentAmount { get; set; }

        [Column(TypeName = "date")]
        public DateTime PaymentDate { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal BalanceAfterPayment { get; set; }
    }
}
