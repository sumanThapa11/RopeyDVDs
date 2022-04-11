using System.ComponentModel.DataAnnotations;

namespace Ropey_DVDs.Models
{
    public class Producer
    {
        [Key]
        public Guid ProducerNumber { get; set; }

        [Required][MaxLength(50)]
        public String ProducerName { get; set; }

        public ICollection<DVDTitle>? DVDTitles { get; set; }
    }
}
