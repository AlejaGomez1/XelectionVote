namespace XelectionVote.Web.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class SeedDb
    {
        private readonly DataContext context;
        private Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Events.Any())
            {
                this.AddEvent("Ganaremos distribuida?");
                this.AddEvent("Ganaremos Optimizacion?");
                this.AddEvent("Nos subiran el salario?");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddEvent (string name)
        {
            this.context.Events.Add(new Event
            {
                Name = name,
                Description = "Ganaremos todo",
            });
        }
    }

}
