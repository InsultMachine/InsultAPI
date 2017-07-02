using Data.Repository;

namespace Data.Presistence
{
    public interface IUnitOfWork
    {
        void Complete();
        InsultRepository Insults { get; }
    }
}