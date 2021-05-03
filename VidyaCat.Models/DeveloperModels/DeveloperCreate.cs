using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat.Data;

namespace VidyaCat.Models.DeveloperModels
{
    public class DeveloperCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Developer name must be longer than 2 characters. This isn't Sesame Street.")]
        [MaxLength(100, ErrorMessage = "Developer name cannot be longer than 100 characters. Fiona Apple isn't a game dev.")]
        [Display(Name = "Developer Name")]
        public string DeveloperName { get; set; }

        [Required]
        public Region Region { get; set; }

        [Display(Name = "Major Studio?")]
        public bool IsMajor { get; set; }

        [Display(Name = "Currently Active?")]
        public bool IsActive { get; set; }
    }
}
