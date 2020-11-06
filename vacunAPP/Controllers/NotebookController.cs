using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using vacunAPP.Core;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vacunAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotebookController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public NotebookController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        // GET: api/<NotebookController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<NotebookController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NotebookController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NotebookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NotebookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
