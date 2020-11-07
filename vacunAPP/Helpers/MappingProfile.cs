using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;
using vacunAPP.ViewModels;

namespace vacunAPP.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<Center, CenterViewModel>().ReverseMap();
            CreateMap<Person, UserViewModel>().ReverseMap();
            CreateMap<Vaccine, VaccineViewModel>().ReverseMap();
            CreateMap<Notebook, NotebookViewModel>().ReverseMap();
            CreateMap<Professional, ProfessionalViewModel>().ReverseMap();
            CreateMap<Person, PersonViewModel>().ReverseMap();



        

        }
    }
}
