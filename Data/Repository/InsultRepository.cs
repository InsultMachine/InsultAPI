using System.Data.Entity;
using System.Linq;
using Data.Models;

namespace Data.Repository
{
    public class InsultRepository : IInsultRepository
    {
        private readonly InsultContext _applicationContext;
        public InsultRepository(InsultContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public IQueryable<Insult> GetAll()
        {
            return _applicationContext.Insults;
        }

        public Insult FindById(int id)
        {
            return _applicationContext.Insults.FirstOrDefault(t => t.InsultId == id);
        }

        public void Add(Insult insult)
        {
            _applicationContext.Insults.Add(insult);
            SaveChanges();
        }

        public void Delete(Insult insult)
        {
            _applicationContext.Insults.Remove(insult);
            SaveChanges();
        }

        public void IncRating(int id)
        {
            var insult = FindById(id);
            insult.Rating++;
            SaveChanges();
        }

        public void DecRating(int id)
        {
            var insult = FindById(id);
            insult.Rating--;
            SaveChanges();
        }

        private void SaveChanges()
        {
            _applicationContext.SaveChanges();
        }
    }
}
