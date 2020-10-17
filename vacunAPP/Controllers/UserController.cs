using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using vacunAPP.Core;
using vacunAPP.Core.Domain;
using vacunAPP.Data;
using vacunAPP.Helpers;
using vacunAPP.ViewModels;

namespace vacunAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        private IConfiguration _config;

        public UserController(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration config)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _config = config;
        }

        [HttpPost]
        [Route("SignIn")]
        public IActionResult Post([FromBody] UserViewModel signIn)
        {
            User user = new User();
            signIn.password = BaseEncodeDecode.Base64Encode(signIn.password);
            user = _mapper.Map<User>(signIn);
            _unitOfWork.User.Add(user);
            _unitOfWork.Complete();
            return Ok();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginViewModel loginUser)
        {
            IActionResult response = Unauthorized();
            User user = await _unitOfWork.User.GetUserProfile(loginUser.UserName);
            UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);
            if (loginUser.Password == BaseEncodeDecode.Base64Decode(user.password))
            {
                userViewModel.token = GenerateJSONWebToken(userViewModel);                
                response = Ok(userViewModel);
            }
            return response;
        }

        private string GenerateJSONWebToken(UserViewModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.Name),
                new Claim(JwtRegisteredClaimNames.Email, userInfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

