using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Linq;
using System.Runtime.InteropServices;

namespace LogisticService.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create<TEntity>(TEntity entity);
        IEnumerable<TEntity> Get();
        void Update(TEntity entity);
        void Delete<TEntity>(TEntity entity);


    }
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IApplicationDbContext _context;

        public Repository(IApplicationDbContext context)
        {
            _context = context;
        }

        public void Create<TEntity>(TEntity entity) => _context.Create(entity);

        public void Delete<TEntity>(TEntity entity) => _context.Delete(entity);

        public IEnumerable<TEntity> Get() => _context.Set<TEntity>().ToList();

        public void Update(TEntity entity) => _context.SetModified(entity);
    }

    
}
