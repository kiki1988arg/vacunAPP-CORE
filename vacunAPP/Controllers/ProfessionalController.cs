using AutoMapper;
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
using vacunAPP.Core;
using vacunAPP.Core.Domain;
using vacunAPP.Helpers;
using vacunAPP.ViewModels;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vacunAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionalController : ControllerBase
    {

        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        private IConfiguration _config;

        public ProfessionalController(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration config)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _config = config;
        }
        // GET: api/<ProfessionalController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProfessionalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProfessionalController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProfessionalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProfessionalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginViewModel loginUser)
        {
            IActionResult response = BadRequest();
            Professional user = await _unitOfWork.Professional.GetProfessionalProfile(loginUser.UserName);
            if (user != null)
            {
                ProfessionalViewModel userViewModel = _mapper.Map<ProfessionalViewModel>(user);
                if (loginUser.Password == user.Password)
                {
                    userViewModel.token = GenerateJSONWebToken(user);
                    userViewModel.Name = user.Name;
                    userViewModel.LastName = user.LastName;                    
                    response = Ok(userViewModel);
                }
            }
            return response;
        }

        private string GenerateJSONWebToken(Professional userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim("Id", userInfo.Id.ToString()),
                new Claim(ClaimTypes.NameIdentifier, userInfo.NIF.ToString()),
                new Claim(ClaimTypes.Role, userInfo.Function),


            };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims: claims,
              null,
              expires: DateTime.Now.AddDays(365),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
