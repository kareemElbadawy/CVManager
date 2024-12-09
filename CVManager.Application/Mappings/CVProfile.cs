using AutoMapper;
using CVManager.Application.DTOs.CV;
using CVManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.Mappings
{
    public class CVProfile : Profile
    {
        public CVProfile()
        {
            CreateMap<CV, CVDto>().ReverseMap();
            CreateMap<PersonalInformation, PersonalInformationDto>().ReverseMap(); 
            CreateMap<ExperienceInformation, ExperienceInformationDto>().ReverseMap();
        }
    }
}
