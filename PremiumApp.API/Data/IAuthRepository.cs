using System.Threading.Tasks;
using PremiumApp.API.Models;

namespace PremiumApp.API.Data
{
    public interface IAuthRepository
    {
         double Calculate(string name, string age);
    }
}