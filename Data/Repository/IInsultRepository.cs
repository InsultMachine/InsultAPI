using System.Linq;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repository
{
    public interface IInsultRepository
    {
        Task<Insult> Add(Insult insult);
        Task<Insult> DecRating(int id);
        Task<Insult> Delete(Insult insult);
        Insult FindById(int id);
        IQueryable<Insult> GetAll();
        Task<Insult> IncRating(int id);
    }
}