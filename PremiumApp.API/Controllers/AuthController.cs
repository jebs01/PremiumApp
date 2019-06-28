using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using PremiumApp.API.Data;
using PremiumApp.API.Dtos;
using PremiumApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace PremiumApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;
        public AuthController(IAuthRepository repo, IConfiguration config)
        {
            _config = config;
            _repo = repo;
        }

        [HttpPost("calculate")]
        public async Task<string> Calculate(UserForCalculationDto userForCalculationDto)
        {
            var  i =  _repo.Calculate(userForCalculationDto.Name, 
                                         userForCalculationDto.Age);
            //return StatusCode(200);
            return Convert.ToString(i);
        }
    }
}