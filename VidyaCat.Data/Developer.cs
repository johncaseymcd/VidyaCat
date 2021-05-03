using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidyaCat.Data
{
    public enum Region
    {
        [Display(Name = "North America")]
        North_America = 1,
        Asia,
        Europe,
        [Display(Name = "South America")]
        South_America,
        Africa,
        Australia,
        Unknown
    }

    public class Developer
    {
        [Key]
        public int DeveloperID { get; set; }

        [Required]
        public string DeveloperName { get; set; }

        [Required]
        public Region Region { get; set; }

        public bool IsMajor { get; set; }
        public bool IsActive { get; set; }

        public string Type
        {
            get
            {
                if (!IsMajor) return "Indie";
                return "Major";
            }
        }

        public string Status
        {
            get
            {
                if (!IsActive) return "Inactive";
                return "Active";
            }
        }
    }
}
