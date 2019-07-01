using System.ComponentModel.DataAnnotations;

namespace PremiumApp.API.Dtos
{
    public class UserForCalculationDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        
        public string Age { get; set; }

        [Required]
        public string DateofBirth { get; set; }

        [Required]
        public string Occupation { get; set; }

        [Required]
         public double SumInsured { get; set; }

       [Required]
        public double Premium {get;set;}
    }
}
