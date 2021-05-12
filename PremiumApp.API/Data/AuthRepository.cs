using System;
using System.Threading.Tasks;
using PremiumApp.API.Models;
using Microsoft.EntityFrameworkCore;
using PremiumApp.API.Data;
using PremiumApp.API.Dtos;


namespace PremiumApp.API.Data
{

    // Set OccupationRating to avoid any issues with magic strings
    // and to help clean code and maintainence

   
   // This is a test
   
    public class AuthRepository :IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }
          
        public double Calculate(UserForCalculationDto userForCalculationDto)
        {  
           try{
                double iRiskFactor;
                double iSumInsured;
                PremiumCalculator userPremium;

           
                DateTime dtDOB = Convert.ToDateTime(userForCalculationDto.DateofBirth);
                TimeSpan tsAge = DateTime.Today - dtDOB;
                int iAge = Convert.ToInt32((tsAge.Days) / 365);

                string sSelectedOccupation =userForCalculationDto.Occupation ;
                iSumInsured = Convert.ToInt64(userForCalculationDto.SumInsured);
                      
                
                  
                 
                switch (sSelectedOccupation)
                   {
                       /*
                        Occupation selection options on screen:

                        1 => Select
                        2 => Cleaner
                        3 => Doctor
                        4 => Author
                        5 => Farmer
                        6 => Mechanic
                        7 => Florist

                        */
                       case "Select":
                       iRiskFactor = OccupationRating.NotSet;
                       break;

                       case "Cleaner":
                       iRiskFactor = OccupationRating.LightManual;
                       break;
                   
                       case "Doctor":
                       iRiskFactor = OccupationRating.Professional;
                       break;
                   
                       case "Author":
                       iRiskFactor = OccupationRating.WhiteCollar;
                       break;
                       
                       case "Farmer":
                       iRiskFactor = OccupationRating.HeavyManual;
                       break;
                       
                       case "Mechanic":
                       iRiskFactor = OccupationRating.HeavyManual;
                       break;
                       
                       case "Florist":
                       iRiskFactor = OccupationRating.LightManual;
                       break;
                      
                       default:
                       iRiskFactor = 1;
                       break;
                   }

                    if (iSumInsured > 0 && iRiskFactor >0 && iAge >0)
                    {
                         userPremium = new PremiumCalculator();
                         userPremium.iPremiumSumInsured = iSumInsured;
                         userPremium.iPremiumRiskFactor = iRiskFactor;
                         userPremium.iPremiumAge = iAge;
                         return userPremium.CalculatePremium();
                    }
                    
                    else 
                    return 0;

                  // Calculate and return Premium  value   
                //  return  (iSumInsured * iRiskFactor * iAge) / 1000 * 12;;
           }
           catch (Exception ex){
               string sException = ex.Message;
               return 0;
           }
          
                    
        }



    }
}
