using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ropey_DVDs.Models
{
    public class DVDCopy
    {
        [Key]
        public Guid CopyNumber { get; set; }

        [ForeignKey("DVDTitle")]
        public Guid DVDNumber { get; set; }
        public DVDTitle DVDTitle { get; set; }

        public DateTime DatePurchased { get; set; }
        public ICollection<Loan>? Loans { get; set; }
    }
}
