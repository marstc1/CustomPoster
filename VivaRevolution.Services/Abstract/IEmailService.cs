using System.Net.Mail;

namespace VivaRevolution.Services.Abstract
{
    public interface IEmailService
    {
        void SendMail(string emailSubject, MailMessage emailMessage);
    }
}