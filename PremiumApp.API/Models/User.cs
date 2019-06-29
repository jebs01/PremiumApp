namespace PremiumApp.API.Models
{
    public class User
    {
       
        public string Name { get; set; }
        public string Age { get; set; }

        public string DateofBirth { get; set; }

        public string Occupation { get; set; }

         public double SumInsured { get; set; }
        public double Premium{ get; set;}
    }
}