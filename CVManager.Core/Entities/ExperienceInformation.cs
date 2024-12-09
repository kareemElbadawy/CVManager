using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Core.Entities
{
    public class ExperienceInformation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string CompanyName { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string CompanyField { get; set; }

        // One ExperienceInformation can be associated with many CVs
        public virtual ICollection<CV> CVs { get; set; }
    }
}
