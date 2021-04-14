using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidyaCat.Data
{
    public enum Genre
    {
        Action = 1,
        Adventure, 
        Casual,
        Fighter,
        Horror,
        Narrative,
        Platformer,
        Puzzle,
        Racing,
        RPG,
        Shooter,
        Simulator,
        Sports,
        Strategy
    }

    public enum Subgenre
    {
        TwoD = 1,
        ThreeD,
        Eight_Bit,
        Sixteen_Bit,
        Art,
        Baseball,
        Basketball,
        Battle_Royale,
        Beat_Em_Up,
        Competitive,
        Fantasy,
        First_Person,
        Fitness,
        Football,
        Golf,
        Hockey,
        Indie,
        JRPG,
        Metroidvania,
        MMO,
        Multiplayer,
        Open_World,
        Other,
        Post_Apocalyptic,
        Real_Time,
        Roguelike,
        Sandbox,
        Third_Person,
        Top_Down,
        Turn_Based,
        Visual_Novel,
        Walking_Simulator
    }

    public enum Rating
    {
        EC = 1,
        E,
        KA,
        ETen,
        T,
        M,
        AO
    }

    public class Game
    {
        [Key]
        public int GameID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime ReleaseYear { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public Subgenre FirstSubgenre { get; set; }
        public Subgenre SecondSubgenre { get; set; }
        public Subgenre ThirdSubgenre { get; set; }

        public virtual List<Platform> Consoles { get; set; } = new List<Platform>();

        [ForeignKey(nameof(Developer))]
        public int DeveloperID { get; set; }
        public virtual Developer Developer { get; set; }
    }
}
