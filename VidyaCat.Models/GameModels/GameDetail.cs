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
        public DateTime ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string FirstSubgenre { get; set; }
        public string SecondSubgenre { get; set; }
        public string ThirdSubgenre { get; set; }
        public string Platforms { get; set; }
        public string DeveloperName { get; set; }
    }
}
