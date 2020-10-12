using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vacunAPP.Core;
using vacunAPP.Core.Domain;
using vacunAPP.Data;
using vacunAPP.ViewModels;

namespace vacunAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public UserController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserViewModel signIn)
        {
            User user = new User();
            user = _mapper.Map<User>(signIn);
            _unitOfWork.User.Add(user);               
            _unitOfWork.Complete();
            return Ok();
        }

    }
}

