using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat.Data;

namespace VidyaCat.Models.GameModels
{
    public class GameListItem
    {
        public int GameID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public Rating Rating { get; set; }

        [Display(Name = "Developer")]
        public string DeveloperName { get; set; }
    }
}
