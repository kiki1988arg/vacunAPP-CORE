using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;
using vacunAPP.Core.Repositories;
using vacunAPP.ViewModels;

namespace vacunAPP.Data.Repositories
{
    public class NotebookRepository : EfCoreRepository<Notebook>, IINotebookRepository
    {
        public NotebookRepository(vacunAPPContext context) : base(context)
        {
        }

        public async Task<IEnumerable<NextVaccineViewModel>> GetNextVaccines(string NIF)
        {
            var persons = this._context.Person.Where(p => p.ParentPersonNIF == NIF).ToList();
            List<NextVaccineViewModel> res = new List<NextVaccineViewModel>();
            foreach (var item in persons)
            {
                var month = this.GetMonthDifference(item.BornDate, DateTime.Now);
                var qry = await (from vac in this._context.Vaccine.Where(c=>!this._context.Notebook
                                 .Where(c=> c.NIF == item.NIF)
                                 .Select(b => b.Vaccine.Id)
                                 .Contains(c.Id)
                                 )
                                 from person in this._context.Person
                                 where (
                                 vac.Month - month < 3 && person.NIF == item.NIF)
                                 select new NextVaccineViewModel
                                 {
                                     Name = vac.Name,
                                     PersonName = person.Name,
                                     PersonLastName = person.LastName,
                                     NIF = person.NIF,
                                     Description = vac.Description,
                                     Month = vac.Month,
                                     Gender = person.Gender
                                 }
                        ).ToListAsync();
                res.AddRange(qry);
            }

            return res;
        }

        public async Task<int> GetNextVaccinesCount(string NIF)
        {
            var persons = this._context.Person.Where(p => p.ParentPersonNIF == NIF).ToList();
            int res = 0;
            foreach (var item in persons)
            {
                var month = this.GetMonthDifference(item.BornDate, DateTime.Now);
                var qry = await (from vac in this._context.Vaccine.Where(c => !this._context.Notebook
                                 .Where(c => c.NIF == item.NIF)
                                 .Select(b => b.Vaccine.Id)
                                 .Contains(c.Id)
                                 )
                                 from person in this._context.Person
                                 where (
                                 vac.Month - month < 3 && person.NIF == item.NIF)
                                 select vac
                        ).ToListAsync();
                res += qry.Count();
            }

            return res;
        }
        private int GetMonthDifference(DateTime startDate, DateTime endDate)
        {
            int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;
            return Math.Abs(monthsApart);
        }
    }
}
