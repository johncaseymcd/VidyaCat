namespace VidyaCat.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<VidyaCat.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VidyaCat.Data.ApplicationDbContext context)
        {
            context.Developers.AddOrUpdate<Developer>(new Developer
            {
                DeveloperID = 1,
                DeveloperName = "Nintendo",
                Region = Region.Asia,
                IsActive = true,
                IsMajor = true
            });

            context.Developers.AddOrUpdate<Developer>(new Developer
            {
                DeveloperID = 2,
                DeveloperName = "Naughty Dog",
                Region = Region.North_America,
                IsActive = true,
                IsMajor = true
            });

            context.Developers.AddOrUpdate<Developer>(new Developer
            {
                DeveloperID = 3,
                DeveloperName = "Heart Machine",
                Region = Region.North_America,
                IsActive = true,
                IsMajor = false
            });

            context.Developers.AddOrUpdate<Developer>(new Developer
            {
                DeveloperID = 4,
                DeveloperName = "Croteam",
                Region = Region.Europe,
                IsActive = true,
                IsMajor = false
            });

            context.Developers.AddOrUpdate<Developer>(new Developer
            {
                DeveloperID = 5,
                DeveloperName = "Team Bondi",
                Region = Region.Australia,
                IsActive = false,
                IsMajor = false
            });

            context.Developers.AddOrUpdate<Developer>(new Developer
            {
                DeveloperID = 6,
                DeveloperName = "Sega",
                Region = Region.Asia,
                IsActive = true,
                IsMajor = true
            });

            context.Developers.AddOrUpdate<Developer>(new Developer
            {
                DeveloperID = 7,
                DeveloperName = "Polyphony Digital",
                Region = Region.Asia,
                IsActive = true,
                IsMajor = true
            });

            context.Developers.AddOrUpdate<Developer>(new Developer
            {
                DeveloperID = 8,
                DeveloperName = "CD Projekt",
                Region = Region.Europe,
                IsActive = true,
                IsMajor = true
            });

            context.Developers.AddOrUpdate<Developer>(new Developer
            {
                DeveloperID = 9,
                DeveloperName = "HAL Laboratory",
                Region = Region.Asia,
                IsActive = true,
                IsMajor = true
            });

            context.Developers.AddOrUpdate<Developer>(new Developer
            {
                DeveloperID = 10,
                DeveloperName = "Red Hook Studios",
                Region = Region.North_America,
                IsActive = true,
                IsMajor = false
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 1,
                Brand = Brand.Atari,
                PlatformName = "2600",
                ReleaseDate = new DateTime(1977, 09, 11),
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 2,
                Brand = Brand.Nintendo,
                PlatformName = "Nintendo Entertainment System",
                ReleaseDate = new DateTime(1985, 10, 18)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 3,
                Brand = Brand.Sega,
                PlatformName = "Genesis",
                ReleaseDate = new DateTime(1989, 08, 14)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 4,
                Brand = Brand.Sony,
                PlatformName = "PlayStation",
                ReleaseDate = new DateTime(1995, 09, 09)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 5,
                Brand = Brand.Microsoft,
                PlatformName = "Xbox",
                ReleaseDate = new DateTime(2001, 11, 15)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 6,
                Brand = Brand.Phillips,
                PlatformName = "CD-i",
                ReleaseDate = new DateTime(1991, 12, 3)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 7,
                Brand = Brand.NEC,
                PlatformName = "TurboGrafx-16",
                ReleaseDate = new DateTime(1989, 08, 29)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 8,
                Brand = Brand.PC,
                PlatformName = "PC",
                ReleaseDate = new DateTime(1976, 01, 01)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 9,
                Brand = Brand.Nintendo,
                PlatformName = "Super Nintendo Entertainment System",
                ReleaseDate = new DateTime(1991, 08, 23)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 10,
                Brand = Brand.Sega,
                PlatformName = "Saturn",
                ReleaseDate = new DateTime(1995, 05, 11)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 11,
                Brand = Brand.Sony,
                PlatformName = "PlayStation2",
                ReleaseDate = new DateTime(2000, 10, 26)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 12,
                Brand = Brand.Nintendo,
                PlatformName = "Nintendo 64",
                ReleaseDate = new DateTime(1996, 09, 29)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 13,
                Brand = Brand.Nintendo,
                PlatformName = "GameCube",
                ReleaseDate = new DateTime(2001, 11, 18)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 14,
                Brand = Brand.Microsoft,
                PlatformName = "Xbox 360",
                ReleaseDate = new DateTime(2005, 11, 22)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 15,
                Brand = Brand.Sony,
                PlatformName = "PlayStation 3",
                ReleaseDate = new DateTime(2006, 11, 17)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 16,
                Brand = Brand.Nintendo,
                PlatformName = "Wii",
                ReleaseDate = new DateTime(2006, 11, 19)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 17,
                Brand = Brand.Nintendo,
                PlatformName = "Wii U",
                ReleaseDate = new DateTime(2021, 11, 18)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 18,
                Brand = Brand.Sony,
                PlatformName = "PlayStation 4",
                ReleaseDate = new DateTime(2013, 11, 15)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 19,
                Brand = Brand.Microsoft,
                PlatformName = "Xbox One",
                ReleaseDate = new DateTime(2013, 11, 22)
            });

            context.Platforms.AddOrUpdate<Platform>(new Platform
            {
                PlatformID = 20,
                Brand = Brand.Nintendo,
                PlatformName = "Switch",
                ReleaseDate = new DateTime(2017, 03, 03)
            });

            context.Games.AddOrUpdate<Game>(new Game
            {
                GameID = 1,
                Title = "Super Mario World",
                DeveloperID = 1,
                ReleaseDate = new DateTime(1990, 11, 21),
                Genre = Genre.Platformer,
                FirstSubgenre = Subgenre.TwoD,
                SecondSubgenre = Subgenre.Sixteen_Bit,
                Platforms = new List<string>() { context.Platforms.Find(9).PlatformName}
            });

            context.Games.AddOrUpdate<Game>(new Game
            {
                GameID = 2,
                Title = "Crash Bandicoot",
                DeveloperID = 2,
                ReleaseDate = new DateTime(1996, 09, 09),
                Genre = Genre.Platformer,
                FirstSubgenre = Subgenre.ThreeD,
                Platforms = new List<string>() { context.Platforms.Find(4).PlatformName }
            });

            context.Games.AddOrUpdate<Game>(new Game
            {
                GameID = 3,
                Title = "Hyper Light Drifter",
                DeveloperID = 3,
                ReleaseDate = new DateTime(2016, 03, 31),
                Genre = Genre.Adventure,
                FirstSubgenre = Subgenre.TwoD,
                SecondSubgenre = Subgenre.Sixteen_Bit,
                ThirdSubgenre = Subgenre.Indie,
                Platforms = new List<string>()
                {
                    context.Platforms.Find(8).PlatformName,
                    context.Platforms.Find(18).PlatformName,
                    context.Platforms.Find(19).PlatformName,
                    context.Platforms.Find(20).PlatformName
                }
            });

            context.Games.AddOrUpdate<Game>(new Game
            {
                GameID = 4,
                Title = "The Talos Principle",
                DeveloperID = 4,
                ReleaseDate = new DateTime(2014,12,11),
                Genre = Genre.Puzzle,
                FirstSubgenre = Subgenre.Open_World,
                SecondSubgenre = Subgenre.Post_Apocalyptic,
                ThirdSubgenre = Subgenre.ThreeD,
                Platforms = new List<string>()
                {
                    context.Platforms.Find(8).PlatformName,
                    context.Platforms.Find(18).PlatformName,
                    context.Platforms.Find(19).PlatformName,
                    context.Platforms.Find(20).PlatformName
                }
            });

            context.Games.AddOrUpdate<Game>(new Game
            {
                GameID = 5,
                Title = "L.A. Noire",
                DeveloperID = 5,
                ReleaseDate = new DateTime(2011, 05, 17),
                Genre = Genre.Adventure,
                FirstSubgenre = Subgenre.Open_World,
                SecondSubgenre = Subgenre.Third_Person,
                Platforms = new List<string>()
                {
                    context.Platforms.Find(8).PlatformName,
                    context.Platforms.Find(14).PlatformName,
                    context.Platforms.Find(15).PlatformName,
                    context.Platforms.Find(18).PlatformName,
                    context.Platforms.Find(19).PlatformName,
                    context.Platforms.Find(20).PlatformName
                }
            });

            context.Games.AddOrUpdate<Game>(new Game
            {
                GameID = 6,
                Title = "Streets Of Rage",
                DeveloperID = 6,
                ReleaseDate = new DateTime(1991, 09, 18),
                Genre = Genre.Action,
                FirstSubgenre = Subgenre.Beat_Em_Up,
                SecondSubgenre = Subgenre.TwoD,
                ThirdSubgenre = Subgenre.Sixteen_Bit,
                Platforms = new List<string>() { context.Platforms.Find(3).PlatformName }
            });

            context.Games.AddOrUpdate<Game>(new Game
            {
                GameID = 7,
                Title = "Gran Turismo 4",
                DeveloperID = 7,
                ReleaseDate = new DateTime(2005, 02, 22),
                Genre = Genre.Racing,
                FirstSubgenre = Subgenre.Multiplayer,
                Platforms = new List<string>() { context.Platforms.Find(11).PlatformName }
            });

            context.Games.AddOrUpdate<Game>(new Game
            {
                GameID = 8,
                Title = "The Witcher",
                DeveloperID = 8,
                ReleaseDate = new DateTime(2007, 10, 30),
                Genre = Genre.RPG,
                FirstSubgenre = Subgenre.Real_Time,
                SecondSubgenre = Subgenre.Third_Person,
                ThirdSubgenre = Subgenre.Fantasy,
                Platforms = new List<string>() { context.Platforms.Find(8).PlatformName }
            });

            context.Games.AddOrUpdate<Game>(new Game
            {
                GameID = 9,
                Title = "Earthbound (Mother 2)",
                DeveloperID = 9,
                ReleaseDate = new DateTime(1995, 06, 05),
                Genre = Genre.RPG,
                FirstSubgenre = Subgenre.Turn_Based,
                SecondSubgenre = Subgenre.Sixteen_Bit,
                ThirdSubgenre = Subgenre.JRPG,
                Platforms = new List<string>() { context.Platforms.Find(9).PlatformName }
            });

            context.Games.AddOrUpdate<Game>(new Game
            {
                GameID = 10,
                Title = "Darkest Dungeon",
                DeveloperID = 10,
                ReleaseDate = new DateTime(2016, 01, 19),
                Genre = Genre.RPG,
                FirstSubgenre = Subgenre.Turn_Based,
                SecondSubgenre = Subgenre.Art,
                ThirdSubgenre = Subgenre.TwoD,
                Platforms = new List<string>()
                {
                    context.Platforms.Find(8).PlatformName,
                    context.Platforms.Find(18).PlatformName,
                    context.Platforms.Find(19).PlatformName,
                    context.Platforms.Find(20).PlatformName
                }
            });
        }
    }
}
