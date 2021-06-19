using DesktopAppTrouvaille.Models;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Processors
{
    public interface ILoginProcessor
    {
        Task<LoginResponse> LoginEmployee(string email, string password);
    }
}
