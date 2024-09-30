//using MimeKit;
//using MailKit.Net.Smtp;
//using System.Threading.Tasks;
//namespace EdPro.Models
//{
//    public class EmailService
//    {
//        public async Task SendEmailAsync(string email, string subject, string message)
//        {
//            var emailMessage = new MimeMessage();

//            emailMessage.From.Add(new MailboxAddress("Адміністрація сайта", "seruk435@ukr.net"));
//            emailMessage.To.Add(new MailboxAddress("", email));
//            emailMessage.Subject = subject;
//            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
//            {
//                Text = message
//            };

//            using (var client = new SmtpClient())
//            {
//                client.CheckCertificateRevocation = false;
//                client.ConnectAsync("smtp.ukr.net", 465, true);

//                await client.AuthenticateAsync("seruk435@ukr.net", "Password777Ronaldo");
//                await client.SendAsync(emailMessage);

//                await client.DisconnectAsync(true);
//            }
//        }
//    }
//}

using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;

namespace EdPro.Models
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Адміністрація сайта", "seruk219@gmail.com")); // Ваша Gmail адреса
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                client.CheckCertificateRevocation = false;

                // Підключення до Gmail SMTP через SSL
                await client.ConnectAsync("smtp.gmail.com", 465, true); // Порт 465 для SSL

                // Аутентифікація на Gmail сервері
                await client.AuthenticateAsync("seruk219@gmail.com", "gjou ahdq wwio nwah"); // Використовуйте пароль для програми, якщо увімкнено 2FA

                // Відправка повідомлення
                await client.SendAsync(emailMessage);

                // Відключення від сервера
                await client.DisconnectAsync(true);
            }
        }
    }
}
