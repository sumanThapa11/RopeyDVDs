using System.ComponentModel.DataAnnotations;

namespace Ropey_DVDs.Models
{
    public class MembershipCategory
    {
        [Key]
        public Guid MembershipCategoryNumber { get; set; } 

        public String MembershipCategoryDescription { get; set; }

        public int MembershipCategoryTotalLoans { get; set; }

        public ICollection<Member>? Members { get; set; }
    }
}
