namespace XelectionVote.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using XelectionVote.Web.Data.Entities;

    public class DataContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<Vote> Votes { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
