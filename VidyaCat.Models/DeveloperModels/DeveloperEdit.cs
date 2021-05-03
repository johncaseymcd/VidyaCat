using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat.Data;

namespace VidyaCat.Models.DeveloperModels
{
    public class DeveloperEdit
    {
        public int DeveloperID { get; set; }

        [Display(Name = "Developer Name")]
        public string DeveloperName { get; set; }

        public Region Region { get; set; }

        [Display(Name = "Major Studio?")]
        public bool IsMajor { get; set; }

        [Display(Name = "Currently Active?")]
        public bool IsActive { get; set; }
    }
}
