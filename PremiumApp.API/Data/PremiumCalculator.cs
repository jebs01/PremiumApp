namespace PremiumApp.API.Data
{
   

     public class PremiumCalculator
    {
               public double iPremiumRiskFactor;
               public double iPremiumSumInsured;
               public int iPremiumAge;
                public double CalculatePremium()
                {
                   return   (iPremiumSumInsured * iPremiumRiskFactor * iPremiumAge) / 1000 * 12;;
                }
    }
}
