using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Runtime.InteropServices;

namespace LogisticService.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IApplicationDbContext _context;

        public Repository(IApplicationDbContext context)
        {
            _context = context;
        }

        public void Create<T>(T entity) => _context.Create(entity);

        public void Delete<T>(T entity) => _context.Delete(entity);

        public IEnumerable<TEntity> Get() => _context.Set<TEntity>();

        public void Update(TEntity entity) => _context.SetModified(entity);
    }

    public interface IRepository<TEntity>
    {
        public void Create<T>(T entity);
        public IEnumerable<TEntity> Get();
        public void Update(TEntity entity);
        public void Delete<T>(T entity);


    }
}
