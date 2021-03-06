using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat.Data;

namespace VidyaCat.Models.PlatformModels
{
    public class PlatformDetail
    {
        public int PlatformID { get; set; }
        public Brand Brand { get; set; }

        [Display(Name = "Platform Name")]
        public string PlatformName { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public bool IsCurrent
        {
            get
            {
                return DateTime.Now.Year - ReleaseDate.Year <= 7;
            }
        }

        public string Status
        {
            get
            {
                if (!IsCurrent) return "Retro";
                return "Current";
            }
        }

        [Display(Name = "Games Available")]
        public int GamesOnPlatform { get; set; }
    }
}
