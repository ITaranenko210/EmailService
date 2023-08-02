using LogisticService.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace LogisticService.Data.Emails
{

    public interface IEmailService
    {
        Task<bool> SendAsync(Email email);
    }

    public class EmailService : IEmailService
    {
        private readonly IEmailRepository _emailRepository;
        public EmailService(IEmailRepository emailRepository)
        {
            _emailRepository = emailRepository;
        }

        //1) I create instance of email,
        //2) Adding informaition about sender\receiver BCC and CC.
        //3) Compane content of mail(body, subject, body's html)
        //4) Creating SMTP server, attach SSL if it's needed and another sertificates
        // Connecting to the server, sending mail and when session ended - disconnecting from the server
        public async Task<bool> SendAsync(Email email)
        {
            try
            {
                var mail = new MimeMessage();
                mail.From.Add(new MailboxAddress(email.From, email.From));
                mail.To.Add(MailboxAddress.Parse(email.To));
                var body = new BodyBuilder();
                mail.Subject = email.Subject;
                body.HtmlBody = email.Body;
                mail.Body = body.ToMessageBody();
                using var smtp = new SmtpClient();
                //if (_settings.UseSSL)
                //{
                //    await smtp.ConnectAsync(_settings.Host, _settings.Port, SecureSocketOptions.SslOnConnect, ct);
                //}
                //else if (_settings.UseStartTls)
                //{
                //    await smtp.ConnectAsync(_settings.Host, _settings.Port, SecureSocketOptions.StartTls, ct);
                //}
                await smtp.AuthenticateAsync("_settings.UserName", "_settings.Password");
                await smtp.SendAsync(mail);
                await smtp.DisconnectAsync(true);

                return true;
            }
            catch (Exception)
            {

                return  false;
            }
        }
    }
   
}
