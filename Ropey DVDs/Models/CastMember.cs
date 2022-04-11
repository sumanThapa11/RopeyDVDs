using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ropey_DVDs.Models
{
    public class CastMember
    {
       
        [ForeignKey("DVDTitle")]
        public Guid DVDNumber { get; set; }
        public DVDTitle DVDTitle { get; set; }

        [ForeignKey("Actor")]
        public Guid ActorNumber { get; set; }
        public Actor Actor { get; set; }
    }
}
