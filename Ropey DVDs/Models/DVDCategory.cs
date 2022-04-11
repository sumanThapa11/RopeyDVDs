using System.ComponentModel.DataAnnotations;

namespace Ropey_DVDs.Models
{
    public class DVDCategory
    {
        [Key]
        public Guid CategoryNumber { get; set; }

        public String CategoryDescription { get; set; }

        [Required]
        public Boolean AgeRestricted { get; set; }

        public ICollection<DVDTitle>? DVDTitles { get; set; }
    }
}
