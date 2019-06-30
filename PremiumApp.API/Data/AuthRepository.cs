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

    public static class OccupationRating
    {
            public const double NotSet = 0;
            public const double Professional = 1.0;
            public const double WhiteCollar = 1.25;
             public const double LightManual = 1.5;
            public const double HeavyManual = 1.75;
    }
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


                  

                  // Calculate and return Premium  value   
                  return  (iSumInsured * iRiskFactor * iAge) / 1000 * 12;;
           }
           catch (Exception ex){
               string sException = ex.Message;
               return 0;
           }
          
                    
        }



    }
}
