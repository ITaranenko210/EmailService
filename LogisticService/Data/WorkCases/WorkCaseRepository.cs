using LogisticService.Models;

namespace LogisticService.Data.WorkCases
{
    public class WorkCaseRepository : Repository<WorkCase>, IWorkCaseRepository
    {
        private readonly IApplicationDbContext _context;
        public WorkCaseRepository(IApplicationDbContext context) : base(context)
        {
        }
       
    }

    public interface IWorkCaseRepository : IRepository<WorkCase>
    {

    }
}
