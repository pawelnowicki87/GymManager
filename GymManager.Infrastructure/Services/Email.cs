using GymManager.Application.Common.Interfaces;
using GymManager.Application.Dictionaries;
using MailKit.Net.Smtp;
using MimeKit;


namespace GymManager.Infrastructure.Services
{
    public class Email : IEmail
    {
        public string _hostSmtp;
        public string _port;
        public string _senderEmail;
        public string _senderEmailPassword;
        public string _senderName;
        public string _senderLogin;

        public async Task Update(IAppSettingsService appSettingsService)
        {
            _hostSmtp = await appSettingsService.Get(SettingsDict.HostSmtp);
            _port = Convert.ToInt32(await appSettingsService.Get(SettingsDict.Port));
            _senderEmail = await appSettingsService.Get(SettingsDict.SenderEmail);
            _senderEmailPassword = await appSettingsService.Get(SettingsDict.SenderEmailPassword);
            _senderName = await appSettingsService.Get(SettingsDict.SenderName);
            _senderLogin = await appSettingsService.Get(SettingsDict.SenderLogin);

        }
        public async Task SendAsync(string subject, string body, string to, string attachmentPath = null)
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress(_senderName, _senderEmail));
            message.To.Add(MailboxAddress.Parse(to));
            message.Subject = subject;

            var builder = new BodyBuilder();

            builder.HtmlBody = $@"
<html>
    <head></head>
    <body>
        <div style=""font-size: 16px; padding: 10px; font-family:Arial; line-hight: 1.4;"">
            {body}
        </div>
    </body>
</html>
";

            if (!string.IsNullOrEmpty(attachmentPath))
                builder.Attachments.Add(attachmentPath);

            message.Body = builder.ToMessageBody();
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_hostSmtp, _port,
                    MailKit.Security.SecureSocketOptions.Auto);

                await client.AuthenticateAsync(!string.IsNullOrWhiteSpace(_senderLogin) ? _senderLogin : _senderEmail, _senderEmailPassword);

                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }

        }
    }
}
