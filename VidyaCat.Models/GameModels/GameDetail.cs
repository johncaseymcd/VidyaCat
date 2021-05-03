using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat.Data;

namespace VidyaCat.Models.GameModels
{
    public class GameDetail
    {
        public int GameID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public Subgenre FirstSubgenre { get; set; }
        public Subgenre SecondSubgenre { get; set; }
        public Subgenre ThirdSubgenre { get; set; }
        public Rating Rating { get; set; }
        public string PlatformNames { get; set; }
        public string DeveloperName { get; set; }
    }
}
