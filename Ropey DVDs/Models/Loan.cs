using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ropey_DVDs.Models
{
    public class Loan
    {
        [Key]
        public Guid LoanNumber { get; set; }

        [ForeignKey("LoanType")]
        public Guid LoanTypeNumber { get; set; }
        public LoanType LoanType { get; set; }

        [ForeignKey("DVDCopy")]
        public Guid CopyNumber { get; set; }
        public DVDCopy DVDCopy { get; set; }

        [ForeignKey("Member")]
        public Guid MemberNumber { get; set; }
        public Member Member { get; set; }

        public DateTime DateOut { get; set; }
        public DateTime DateDue { get; set; } 
        public DateTime DateReturned { get; set; }
        


    }
}
