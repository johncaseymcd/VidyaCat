using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat.Data;

namespace VidyaCat.Models.DeveloperModels
{
    public class DeveloperEdit
    {
        public int DeveloperID { get; set; }
        public string Name { get; set; }
        public Region Region { get; set; }
        public bool IsMajor { get; set; }
        public bool IsActive { get; set; }
    }
}
