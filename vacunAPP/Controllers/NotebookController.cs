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
        public ActionResult Post([FromBody] AddNotebookVm notebookVw)
        {
            Notebook nb = new Notebook();
            nb.NIF = notebookVw.NIF;
            nb.VaccineId = notebookVw.VaccineId;
            nb.ProfessionalId = 999999;
            nb.CenterId = 999999;
            nb.ApplicationDate = DateTime.Now;
            this._unitOfWork.Notebook.Add(nb);
            this._unitOfWork.Complete();
            return Ok(200);            
        }

        // POST api/<NotebookController>
        [HttpPost]
        [Route("validate")]
        public ActionResult PostAndValidate([FromBody] AddNotebookVm notebookVw)
        {
            Notebook nb = new Notebook();
            nb.NIF = notebookVw.NIF;
            nb.VaccineId = notebookVw.VaccineId;
            nb.ProfessionalId = int.Parse(User.FindFirst("Id")?.Value); 
            nb.CenterId = 3;
            nb.ApplicationDate = DateTime.Now;
            this._unitOfWork.Notebook.Add(nb);
            this._unitOfWork.Complete();
            return Ok(200);
        }

        // PUT api/<NotebookController>/5
        [HttpPut]
        public async Task<ActionResult> PutAsync([FromBody] AddNotebookVm notebookVw)
        {
            Notebook nb = await this._unitOfWork.Notebook.Get(notebookVw.Id);
            nb.ProfessionalId = int.Parse(User.FindFirst("Id")?.Value);
            nb.CenterId = 3;
            nb.ApplicationDate = DateTime.Now;
            this._unitOfWork.Complete();
            return Ok(200);
        }

        // DELETE api/<NotebookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
