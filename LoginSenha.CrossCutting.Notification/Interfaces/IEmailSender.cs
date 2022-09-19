using System.Collections.Generic;
using System.Threading.Tasks;
using LoginSenha.CrossCutting.Notification.ViewModels;

namespace LoginSenha.CrossCutting.Notification.Interfaces
{
    public interface IEmailSender
    {
        void SendEmail(EmailViewModel message, IEnumerable<string> parameters);
        Task SendEmailAsync(EmailViewModel message, IEnumerable<string> parameters);
    }
}
