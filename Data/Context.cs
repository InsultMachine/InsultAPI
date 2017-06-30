using System.Data.Entity;
using Data.Models;

namespace Data
{
    public class InsultContext : DbContext
    {
        public DbSet<Insult> Insults { get; set; }

        public InsultContext() : base("name=InsultContext")
        {
           
        }
    }
}
