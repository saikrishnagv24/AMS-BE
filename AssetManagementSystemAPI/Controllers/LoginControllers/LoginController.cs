using AssetManagementSystemAPI.DTO;
using AssetManagementSystemAPI.Interfaces.LoginInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Controllers.LoginController
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IloginInterface loginInterface;
        public IConfiguration _configuration { get; }
        public LoginController(IloginInterface _loginInterface, IConfiguration config)
        {
            _configuration = config;
            loginInterface = _loginInterface;
        }

        [HttpPost]
        [Route("LoginData")]
        public IActionResult Post([FromBody] LoginDTO login)
        {
            var userData = loginInterface.Login(login);
            //return data;
            //var userData = loginInterface.PostLoginAsync(loginT.UserName, loginT.Password);
            if (userData != null)
            {
                // return Unauthorized();
                var claims = new Claim[]
                {
                new Claim(ClaimTypes.NameIdentifier, userData.Id.ToString()),
                new Claim(ClaimTypes.Name, userData.Name)
                 };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    Expires = DateTime.Now.AddDays(1),
                    SigningCredentials = creds
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return Ok(new { token = tokenHandler.WriteToken(token), name = userData.Name });
            }
            return BadRequest("Invalid User");

            return Ok("Invalid User");
        }
    }
}
