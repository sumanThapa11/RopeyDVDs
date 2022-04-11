using System.ComponentModel.DataAnnotations;

namespace Ropey_DVDs.Models
{
    public class Actor
    {
        [Key]
        public Guid ActorNumber { get; set; }

        [Required]
        [MaxLength(30)]
        public String ActorSurname { get; set; }

        [MaxLength(50)]
        public String ActorFirstName { get; set; }   

        public ICollection<CastMember>? CastMembers { get; set; }
    }
}
