using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidyaCat.Data
{
    public enum Brand
    {
        Atari = 1,
        Coleco,
        Magnavox,
        Microsoft,
        NEC,
        Nintendo,
        Panasonic,
        PC,
        Phillips,
        Sega,
        SNK,
        Sony,
        Other
    }

    public class Console
    {
        [Key]
        public int ConsoleID { get; set; }

        [Required]
        public Brand Brand { get; set; }

        [Required]
        public string ConsoleName { get; set; }

        [Required]
        public DateTime ReleaseYear { get; set; }

        public bool IsCurrent { get; set; }
    }
}
