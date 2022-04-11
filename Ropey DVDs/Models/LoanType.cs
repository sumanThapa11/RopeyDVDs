using System.ComponentModel.DataAnnotations;

namespace Ropey_DVDs.Models
{
    public class LoanType
    {
        [Key]
        public Guid LoanNumber { get; set; }

        [Required]
        public String LoanName { get; set; }

        [Required]
        public String LoanDuration { get; set; }

        public ICollection<Loan>? Loans { get; set; }


    }
}
