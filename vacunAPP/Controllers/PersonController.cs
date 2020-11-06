using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
    public class PersonController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public PersonController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        // GET: api/<PersonController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("me")]
        public async Task<IEnumerable<PersonViewModel>> GetMyPersons()
        {
            var persons = await this._unitOfWork.Person.GetPersonsById(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            IEnumerable<PersonViewModel> personList = this._mapper.Map<IEnumerable<Person>, IEnumerable<PersonViewModel>>(persons);
            return personList;
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<Person> Get(string id)
        {
            var res=  await this._unitOfWork.Person.GetPersonByNIF(id);
            return res;
        }


        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonViewModel personVW)
        {
            Person person = _mapper.Map<Person>(personVW);
            person.ParentPersonNIF = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            this._unitOfWork.Person.Add(person);
            this._unitOfWork.Complete();
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
