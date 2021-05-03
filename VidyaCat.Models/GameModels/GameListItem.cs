using System;
using System.Collections.Generic;
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
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public Rating Rating { get; set; }
        public string DeveloperName { get; set; }
    }
}
