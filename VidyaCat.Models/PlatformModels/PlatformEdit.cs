using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat.Data;

namespace VidyaCat.Models.PlatformModels
{
    public class PlatformEdit
    {
        public int PlatformID { get; set; }
        public Brand Brand { get; set; }

        [Display(Name = "Platform Name")]
        public string PlatformName { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
    }
}
