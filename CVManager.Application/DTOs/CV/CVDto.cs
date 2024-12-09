using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.DTOs.CV
{
    public class CVDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PersonalInformationId { get; set; }
        public int ExperienceInformationId { get; set; }
        public PersonalInformationDto PersonalInformation { get; set; }
        public ExperienceInformationDto ExperienceInformation
        {
            get; set;
        }
    }
}
