using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ropey_DVDs.Models;


namespace Ropey_DVDs.Data
{
    public class RopeyDBContext: IdentityDbContext<IdentityUser>
    {
        public RopeyDBContext(DbContextOptions<RopeyDBContext> dbContext):base(dbContext)
        { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configure composite primary key for CastMember
            modelBuilder.Entity<CastMember>().HasKey(s => new { s.DVDNumber, s.ActorNumber });
        }

        public DbSet<Actor> Actors { get; set; } 
        public DbSet<Studio> Studios { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<DVDCategory> DVDCategories { get; set; }
        public DbSet<LoanType> LoanTypes { get; set; }
        public DbSet<MembershipCategory> MembershipCategories { get; set; }
        public DbSet<DVDTitle> DVDTitles { get; set; }
        public DbSet<CastMember> CastMembers { get; set; }
        public DbSet<DVDCopy> DVDCopies { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Member> Members { get; set; }



    }

}
