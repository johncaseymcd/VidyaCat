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
        public DateTime ReleaseYear { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public Subgenre FirstSubgenre { get; set; }
        public Subgenre SecondSubgenre { get; set; }
        public Subgenre ThirdSubgenre { get; set; }

        [Required]
        public string PlatformNames { get; set; }

        [Required]
        public string DeveloperName { get; set; }
    }
}
