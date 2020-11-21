using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using vacunAPP.Core;
using vacunAPP.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vacunAPP.Controllers
{
    [Authorize]
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

        // GET api/<NotebookController>/5
        [HttpGet]
        public async Task<IEnumerable<NextVaccineViewModel>> GetAsync()
        {
            var res = await this._unitOfWork.Notebook.GetNextVaccines(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            List<NextVaccineViewModel> vList = new List<NextVaccineViewModel>();
            return res;
 
        }

        [HttpGet]
        [Route("count")]
        public async  Task<int> GetNextVaccinesCount()
        {
            var res = await this._unitOfWork.Notebook.GetNextVaccinesCount(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            return res;
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
