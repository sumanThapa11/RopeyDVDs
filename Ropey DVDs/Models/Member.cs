using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ropey_DVDs.Models
{
    public class Member
    {
        [Key]
        public Guid MemberNumber { get; set; }

        [ForeignKey("MembershipCategory")]
        public Guid MembershipCategoryNumber { get; set; }
        public MembershipCategory MembershipCategory { get; set; }

        [Required]
        [MaxLength(50)]
        public String MemberLastName { get; set; }
        [MaxLength(100)]
        public string MemberFirstName { get; set; }
        [MaxLength(50)]
        public string MemberAddress { get; set; }
        public DateTime MemberDateOfBirth { get; set; }
    }
}
