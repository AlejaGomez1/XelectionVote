namespace XelectionVote.Web.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Entities;


    public class SeedDb
    {
        private readonly DataContext context;
        private readonly UserManager<User> userManager;
        private Random random;

        public SeedDb(DataContext context, UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userManager.FindByEmailAsync("malejalgomez@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Maria",
                    LastName = "Gomez",
                    Email = "malejalgomez@gmail.com",
                    UserName = "malejalgomez@gmail.com",
                    PhoneNumber = "318269858"
                };

                var result = await this.userManager.CreateAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

            if (!this.context.Events.Any())
            {
                this.AddEvent("Ganaremos distribuida?", user);
                this.AddEvent("Ganaremos Optimizacion?", user);
                this.AddEvent("Nos subiran el salario?", user);
                await this.context.SaveChangesAsync();
            }
        }

        private void AddEvent (string name, User user)
        {
            this.context.Events.Add(new Event
            {
                Name = name,
                Description = "Ganaremos todo",
                User = user
            });
        }
    }
}
