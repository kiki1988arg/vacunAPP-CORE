using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using vacunAPP.Core;
using vacunAPP.Core.Domain;
using vacunAPP.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vacunAPP.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InstituteController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public InstituteController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        // GET: api/<InstituteController>
        [HttpGet]
        public async Task<IEnumerable<InstituteViewModel>> Get()
        {            
            var InstituteList  = await this._unitOfWork.Institute.GetAll();
            IEnumerable<InstituteViewModel> res = _mapper.Map<IEnumerable<Institute>, IEnumerable<InstituteViewModel>>(InstituteList);
            return res;           
            
        }

        // GET api/<InstituteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InstituteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InstituteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InstituteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
