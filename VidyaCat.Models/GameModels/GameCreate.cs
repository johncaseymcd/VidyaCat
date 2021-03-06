using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat.Data;

namespace VidyaCat.Models.GameModels
{
    public class GameCreate
    {
        [Required]
        [MaxLength(500, ErrorMessage = "Game title cannot be longer than 500 characters. If it is, stop it. Get some help.")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Display(Name = "Subgenre 1")]
        public Subgenre FirstSubgenre { get; set; }

        [Display(Name = "Subgenre 2")]
        public Subgenre SecondSubgenre { get; set; }

        [Display(Name = "Subgenre 3")]
        public Subgenre ThirdSubgenre { get; set; }

        public Rating Rating { get; set; }

        [Required]
        [Display(Name = "Platforms (comma separated)")]
        public string PlatformNames { get; set; }

        [Required]
        [Display(Name = "Developer Name")]
        public string DeveloperName { get; set; }
    }
}
