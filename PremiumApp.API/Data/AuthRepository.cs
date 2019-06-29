using System;
using System.Threading.Tasks;
using PremiumApp.API.Models;
using Microsoft.EntityFrameworkCore;
using PremiumApp.API.Data;
using PremiumApp.API.Dtos;

namespace PremiumApp.API.Data
{
    public class AuthRepository :IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }
       


        public double Calculate(UserForCalculationDto userForCalculationDto)
        {  
                DateTime dt1 = Convert.ToDateTime(userForCalculationDto.DateofBirth);
                TimeSpan ts = DateTime.Today - dt1;

                   int iAge = Convert.ToInt32((ts.Days) / 365);
                   string strOccupation =userForCalculationDto.Occupation ;
                      
                      // TODO : Move to Enum to avoid magic strings
                   double iRiskFactor = 1;
                   if (strOccupation == "Light Manual")
                   iRiskFactor = 1.75;
                    if (strOccupation == "Heavy Manual")
                   iRiskFactor = 1.5;
                    if (strOccupation == "White Collar")
                   iRiskFactor = 1.25;
                    if (strOccupation == "Professional")
                   iRiskFactor = 1;

                   double iSumInsured = Convert.ToInt64(userForCalculationDto.SumInsured);
                    return  (iSumInsured * iRiskFactor * iAge) / 1000 * 12;;
                    //return 1200;
        }



    }
}