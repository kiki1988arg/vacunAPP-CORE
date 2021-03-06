﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vacunAPP.Core;
using vacunAPP.Core.Domain;
using vacunAPP.Helpers;
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
        public async Task<PersonViewModel> Get(string id)
        {
            var res=  await this._unitOfWork.Person.GetPersonByNIF(id);
            PersonViewModel vw = _mapper.Map<Person, PersonViewModel>(res);
            var vacVw = await this._unitOfWork.Vaccines.GetPersonVaccines(vw.NIF);
            vw.Vaccines = _mapper.Map<IEnumerable<Vaccine>, IEnumerable<VaccineViewModel>>(vacVw);
            return vw;
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

        //[HttpPost]
        //[Route("upload")]
        //public async Task<ActionResult> UploadProfilePicture()
        //{
        //    IFormFile file = Request.Form.Files[0];
        //    if (file == null)
        //    {
        //        return BadRequest();
        //    }

        //    var result = await _blobService.UploadFileBlobAsync(
        //            "firstcontainer",
        //            file.OpenReadStream(),
        //            file.ContentType,
        //            file.FileName);

        //    var toReturn = result.AbsoluteUri;

        //    return Ok(new { path = toReturn });
        //}

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
