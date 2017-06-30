using Data.Models;
using System.Data.Entity.Migrations;

namespace Data.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<Data.InsultContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.InsultContext context)
        {
            context.Insults.AddOrUpdate(
                new Insult { InsultId = 1, Text = "Fuck you", Rating = 1},
                new Insult { InsultId = 2, Text = "Blow me", Rating = 1}
                );
        }
    }
}
