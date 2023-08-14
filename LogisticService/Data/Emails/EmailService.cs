using LogisticService.Data.Options;
using LogisticService.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;

namespace LogisticService.Data.Emails
{

    public interface IEmailService
    {
        Task<bool> SendAsync(Email email, CancellationToken ct = default);
    }

    public class EmailService : IEmailService
    {
        private readonly IEmailRepository _emailRepository;
        private readonly MailOptions _options;
        public EmailService(IEmailRepository emailRepository, IOptions<MailOptions> options)
        {
            _emailRepository = emailRepository;
            _options = options.Value;
        }

        //1) I create instance of email,
        //2) Adding informaition about sender\receiver BCC and CC.
        //3) Compane content of mail(body, subject, body's html)
        //4) Creating SMTP server, attach SSL if it's needed and another sertificates
        // Connecting to the server, sending mail and when session ended - disconnecting from the server
        public async Task<bool> SendAsync(Email email, CancellationToken ct = default)
        {
            try
            {
                var mail = new MimeMessage();
                mail.From.Add(new MailboxAddress(_options.DisplayName, email.From ?? _options.From));
                mail.To.Add(MailboxAddress.Parse(email.To));
                var body = new BodyBuilder();
                mail.Subject = email.Subject;
                body.HtmlBody = email.Body;
                mail.Body = body.ToMessageBody();
                using var smtp = new SmtpClient();
                if (_options.UseSSL)
                {
                    await smtp.ConnectAsync(_options.Host, _options.Port, SecureSocketOptions.SslOnConnect, ct);
                }
                else if (_options.UseStartTls)
                {
                    await smtp.ConnectAsync(_options.Host, _options.Port, SecureSocketOptions.StartTls, ct);
                }
                await smtp.AuthenticateAsync(_options.UserName, _options.Password, ct);
                await smtp.SendAsync(mail, ct);
                await smtp.DisconnectAsync(true, ct);

                return true;
            }
            catch (Exception)
            {

                return  false;
            }
        }
    }
   
}
