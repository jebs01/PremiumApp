using System.Threading.Tasks;
using PremiumApp.API.Models;
using PremiumApp.API.Data;
using PremiumApp.API.Dtos;

namespace PremiumApp.API.Data
{
    public interface IAuthRepository
    {
         double Calculate(UserForCalculationDto userForCalculationDto);
    }
}