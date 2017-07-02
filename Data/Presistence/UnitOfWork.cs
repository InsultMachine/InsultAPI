using Data.Repository;

namespace Data.Presistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InsultContext _context;

        public InsultRepository Insults { get; private set; }

        public UnitOfWork(InsultContext context)
        {
            _context = context;
            Insults = new InsultRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}