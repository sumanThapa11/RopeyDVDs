using System.ComponentModel.DataAnnotations;

namespace Ropey_DVDs.Models
{
    public class Studio
    {
        [Key]
        public Guid StudioNumber { get; set; }

        [Required][MaxLength(100)]
        public String StudioName { get; set; }

        public ICollection<DVDTitle>? DVDTitles { get; set; }
    }
}
