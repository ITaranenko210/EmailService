namespace LogisticService.Data.Emails
{
    public class EmailRepository : Repository<EmailRepository>, IEmailRepository
    {
        public EmailRepository(IApplicationDbContext context) : base(context)
        {

        }
    }
    interface IEmailRepository
    {

    }
}
