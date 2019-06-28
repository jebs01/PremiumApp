using System.ComponentModel.DataAnnotations;

namespace PremiumApp.API.Dtos
{
    public class UserForCalculationDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        
        public string Age { get; set; }

        
    }
}