using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat.Data;

namespace VidyaCat.Models.GameModels
{
    public class GameEdit
    {
        public int GameID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Subgenre 1")]
        public Subgenre FirstSubgenre { get; set; }

        [Display(Name = "Subgenre 2")]
        public Subgenre SecondSubgenre { get; set; }

        [Display(Name = "Subgenre 3")]
        public Subgenre ThirdSubgenre { get; set; }
        public Rating Rating { get; set; }

        [Display(Name = "Platforms (comma separated)")]
        public string PlatformNames { get; set; }

        [Display(Name = "Developer Name")]
        public string DeveloperName { get; set; }
    }
}
