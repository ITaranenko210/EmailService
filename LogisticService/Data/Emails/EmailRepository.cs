namespace LogisticService.Data.Emails
{
    public class EmailRepository : Repository<EmailRepository>, IEmailRepository
    {
        private readonly IApplicationDbContext _context;
        public EmailRepository(IApplicationDbContext context) : base(context)
        {

        }
    }
    public interface IEmailRepository
    {

    }
}
