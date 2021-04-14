﻿using System;
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
        public DateTime ReleaseYear { get; set; }
        public Genre Genre { get; set; }
        public Subgenre FirstSubgenre { get; set; }
        public Subgenre SecondSubgenre { get; set; }
        public Subgenre ThirdSubgenre { get; set; }
        public string PlatformNames { get; set; }
        public string DeveloperName { get; set; }
    }
}
