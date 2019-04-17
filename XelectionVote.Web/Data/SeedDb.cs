﻿namespace XelectionVote.Web.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using Helpers;
    using Microsoft.AspNetCore.Identity;

    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private readonly Random random;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userHelper.GetUserByEmailAsync("malejalgomez@gmail.com");
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

                var result = await this.userHelper.AddUserAsync(user, "123456");
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

        private void AddEvent(string name, User user)
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
