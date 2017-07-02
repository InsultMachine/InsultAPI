using System.Linq;
using System.Threading.Tasks;
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

        public Task<Insult> Add(Insult insult)
        {
            _applicationContext.Insults.Add(insult);
            return Task.FromResult(new Insult());
        }

        public Task<Insult> Delete(Insult insult)
        {
            _applicationContext.Insults.Remove(insult);
            return Task.FromResult(new Insult());
        }

        public Task<Insult> IncRating(int id)
        {
            var insult = FindById(id);
            insult.Rating++;
            return Task.FromResult(new Insult());
        }

        public Task<Insult> DecRating(int id)
        {
            var insult = FindById(id);
            insult.Rating--;
            return Task.FromResult(new Insult());
        }
    }
}
