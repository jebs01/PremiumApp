using System.ComponentModel.DataAnnotations;

namespace PremiumApp.API.Dtos
{
    public class UserForCalculationDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        
        public string Age { get; set; }

        public string DateofBirth { get; set; }

        public string Occupation { get; set; }

         public double SumInsured { get; set; }

        public double Premium {get;set;}
    }
}