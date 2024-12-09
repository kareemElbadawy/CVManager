using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.DTOs.CV
{
    public class PersonalInformationDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string CityName { get; set; }
        [EmailAddress] 
        public string Email { get; set; }
        [Phone] 
        public string MobileNumber { get; set; }
    }

}
