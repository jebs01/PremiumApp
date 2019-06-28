using System;
using System.Threading.Tasks;
using PremiumApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace PremiumApp.API.Data
{
    public class AuthRepository :IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }
       


        public double Calculate(string name, string age)
        {
           



            // DateTime dt1 = Convert.ToDateTime(user.DateofBirth);
                    //  Convert.ToDateTime(txtDOB.Text, "dd/MM/yyyy");
                    //DateTime.Parse(txtDOB.Text, "dd/MM/yyyy");

                   // Convert.ToDateTime(txtDOB.Text);
                    // DateTime dt2 = Convert.ToDateTime(txtDOB.Text)

                    //TimeSpan ts = DateTime.Today - dt1;

                   // txtAge.Text = Convert.ToString((ts.Days) / 365);


                    //Response.Write("Hello");
                    //int i = Request.Form["txtAge"].

                    //string n = String.Format("{0}", Request.Form["txtAge"]);
                   // int iAge = Convert.ToInt32(user.Age);
                   // double iCoverAmount = Convert.ToDouble(user.SumInsured);
                    //double iRiskFactor = Convert.ToDouble(user.Occupation);
                    //double iPremium = (iCoverAmount * iRiskFactor * iAge) / 1000 * 12;

                    return  800;
        }



    }
}