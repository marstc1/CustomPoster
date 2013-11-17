using System;
using System.Net.Mail;
using VivaRevolution.Services.Abstract;

namespace VivaRevolution.Services.EmailService
{
    public class ViaEmailService : IEmailService
    {
        public void SendMail(string emailSubject, MailMessage emailMessage)
        {
            try
            {
                emailMessage.Subject = emailSubject;

                SmtpClient smtp = new SmtpClient();

                smtp.Host = "smtp.via.novonet";
                smtp.Port = 25;
                smtp.Timeout = 1200000;
                smtp.Send(emailMessage);
            }
            catch (Exception technicalException)
            {
                throw technicalException;
            }
        }
    }
}
