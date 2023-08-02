namespace LogisticService.Data.WorkCases
{
    public class WorkCaseRepository : Repository<WorkCaseRepository>, IWorkCaseRepository
    {
        private readonly IApplicationDbContext _context;
        public WorkCaseRepository(IApplicationDbContext context) : base(context)
        {
        }
    }

    public interface IWorkCaseRepository
    {

    }
}
