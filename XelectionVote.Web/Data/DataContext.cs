namespace XelectionVote.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using XelectionVote.Web.Data.Entities;

    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Event> Events { get; set; }

        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<Vote> Votes { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
