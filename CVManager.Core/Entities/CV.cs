using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Core.Entities
{
    public class CV
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]  // Maximum length for Name
        public string Name { get; set; }

        [Required]
        public int PersonalInformationId { get; set; }

        [ForeignKey("PersonalInformationId")]
        public virtual PersonalInformation PersonalInformation { get; set; }

        [Required]
        public int ExperienceInformationId { get; set; }

        [ForeignKey("ExperienceInformationId")]
        public virtual ExperienceInformation ExperienceInformation { get; set; }
    }
}
