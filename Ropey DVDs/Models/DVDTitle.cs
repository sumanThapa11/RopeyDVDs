using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ropey_DVDs.Models
{
    public class DVDTitle
    {
        [Key]
        public Guid DVDNumber { get; set; }

        [ForeignKey("DVDCategory")]
        public Guid CategoryNumber { get; set; }
        public DVDCategory? DVDCategory { get; set; }

        [ForeignKey("Studio")]
        public Guid StudioNumber { get; set; }
        public Studio? Studio { get; set; }


        [ForeignKey("Producer")]
        public Guid ProducerNumber { get; set; }
        public Producer? Producer { get; set; }

        [MaxLength(80)]
        public String? Title { get; set; }
        public DateTime DateReleased { get; set; }

        [Column(TypeName="decimal(9,2)")]
        public Decimal StandardCharge { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public Decimal PenaltyCharge { get; set; }

        public ICollection<CastMember>? CastMembers { get; set; }

        public ICollection<DVDCopy>? DVDCopies { get; set; }
    }
}
