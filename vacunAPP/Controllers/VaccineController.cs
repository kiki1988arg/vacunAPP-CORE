using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vacunAPP.Core;
using vacunAPP.Core.Domain;
using vacunAPP.Data;

namespace vacunAPP.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public VaccineController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<Vaccine>> Get()
        {
            return await _unitOfWork.Vaccines.GetAll();
        }

        // GET api/<Vaccines>/5
        [HttpGet("{id}")]
        public async Task<Vaccine> Get(int id)
        {
            return await _unitOfWork.Vaccines.Get(id);
        }

        [HttpPost]
        public IActionResult Post()
        {
            var vac = new Vaccine
            {
                Name = "Mi vacuna"
            };

            _unitOfWork.Vaccines.Add(vac);
            _unitOfWork.Complete();

            return Ok();
        }
    }
}
