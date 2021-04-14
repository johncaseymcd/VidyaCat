using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat.Data;

namespace VidyaCat.Models.PlatformModels
{
    public class PlatformCreate
    {
        [Required]
        public Brand Brand { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Platform name must be at least 2 characters. Must be, y'know, a real platform.")]
        [MaxLength(100, ErrorMessage = "Platform name must be less than 100 characters. Were you trying to list the whole production staff?")]
        public string PlatformName { get; set; }

        [Required]
        public DateTime ReleaseYear { get; set; }
    }
}
