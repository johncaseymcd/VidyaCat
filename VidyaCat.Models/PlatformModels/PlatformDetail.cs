using System;
using System.Collections.Generic;
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
        public string PlatformName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsCurrent { get; set; }
        public List<string> GamesOnPlatform { get; set; }
    }
}
