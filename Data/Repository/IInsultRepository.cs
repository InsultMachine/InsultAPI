using System.Linq;
using Data.Models;

namespace Data.Repository
{
    public interface IInsultRepository
    {
        void Add(Insult insult);
        void DecRating(int id);
        void Delete(Insult insult);
        Insult FindById(int id);
        IQueryable<Insult> GetAll();
        void IncRating(int id);
    }
}