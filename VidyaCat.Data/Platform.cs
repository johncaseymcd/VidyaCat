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

    public class Platform
    {
        [Key]
        public int PlatformID { get; set; }

        [Required]
        public Brand Brand { get; set; }

        [Required]
        public string PlatformName { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public bool IsCurrent
        {
            get
            {
                return (DateTime.Now.Year - ReleaseDate.Year) <= 10;
            }
        }

        public string Status
        {
            get
            {
                if (!IsCurrent) return "Retro";
                return "Current";
            }
        }
    }
}
