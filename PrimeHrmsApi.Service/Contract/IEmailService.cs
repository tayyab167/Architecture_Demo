using PrimeHrmsApi.Domain.Settings;
using System.Threading.Tasks;

namespace PrimeHrmsApi.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
