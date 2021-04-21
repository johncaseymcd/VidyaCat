
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat.Data;
using VidyaCat.Models.GameModels;

namespace VidyaCat.Services
{
    public class GameService
    {
        private readonly Guid _userID;

        public GameService(Guid userID)
        { 
            _userID = userID;
        }

        public bool CreateGame(GameCreate model)
        {
            var entity =
                new Game()
                {
                    //UserID = _userID,
                    Title = model.Title,
                    ReleaseDate = model.ReleaseYear,
                    Genre = model.Genre,
                    FirstSubgenre = model.FirstSubgenre,
                    SecondSubgenre = model.SecondSubgenre,
                    ThirdSubgenre = model.ThirdSubgenre
                };

            using (var ctx = new ApplicationDbContext())
            {
                var dev = ctx.Developers.Single(d => d.DeveloperName == model.DeveloperName);
                entity.DeveloperID = dev.DeveloperID;
                ctx.Games.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<GameListItem> GetGames()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Games
                    .Select(
                        g =>
                        new GameListItem
                        {
                            GameID = g.GameID,
                            Title = g.Title,
                            ReleaseDate = g.ReleaseDate,
                            Genre = Enum.GetName(typeof(Genre), g.Genre.GetHashCode()),
                            DeveloperName = g.Developer.DeveloperName,
                            Platforms = g.Platforms.ToString()
                        }
                    );

                return query.ToList();
            }
        }

        public GameDetail GetGameByID(int gameID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Games
                    .Find(gameID);

                return new GameDetail
                {
                    GameID = entity.GameID,
                    Title = entity.Title,
                    ReleaseDate = entity.ReleaseDate,
                    Genre = entity.Genre,
                    FirstSubgenre = entity.FirstSubgenre,
                    SecondSubgenre = entity.SecondSubgenre,
                    ThirdSubgenre = entity.ThirdSubgenre,
                    DeveloperName = entity.Developer.DeveloperName,
                    PlatformNames = entity.Platforms.ToString()
                };
            }
        }

        public IEnumerable<GameListItem> GetGamesByDeveloper(int devID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Games
                    .Where(g => g.DeveloperID == devID)
                    .Select(
                        g =>
                        new GameListItem
                        {
                            GameID = g.GameID,
                            Title = g.Title,
                            ReleaseDate = g.ReleaseDate,
                            Genre = Enum.GetName(typeof(Genre), g.Genre.GetHashCode()),
                            DeveloperName = g.Developer.DeveloperName,
                            Platforms = g.Platforms.ToString()
                        }
                    );

                return query.ToList();
            }
        }

        public IEnumerable<GameListItem> GetGamesByPlatform(int platID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var platform = ctx.Platforms.Find(platID);

                var query =
                    ctx.Games
                    .Where(g => g.Platforms.Contains(platform))
                    .Select(
                        g =>
                        new GameListItem
                        {
                            GameID = g.GameID,
                            Title = g.Title,
                            ReleaseDate = g.ReleaseDate,
                            Genre = Enum.GetName(typeof(Genre), g.Genre.GetHashCode())
                        }
                    );

                return query.ToList();
            }
        }

        public IEnumerable<GameListItem> GetGamesByYear(DateTime year)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Games
                    .Where(g => g.ReleaseDate.Year == year.Year)
                    .Select(
                       g =>
                       new GameListItem
                       {
                           GameID = g.GameID,
                           Title = g.Title,
                           ReleaseDate = g.ReleaseDate,
                           Genre = Enum.GetName(typeof(Genre), g.Genre.GetHashCode()),
                           DeveloperName = g.Developer.DeveloperName,
                           Platforms = g.Platforms.ToString()
                       }
                    );

                return query.ToList();
            }
        }

        public IEnumerable<GameListItem> GetGamesByGenre(Genre genre)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Games
                    .Where(g => g.Genre == genre)
                    .Select(
                        g =>
                        new GameListItem
                        {
                            GameID = g.GameID,
                            Title = g.Title,
                            ReleaseDate = g.ReleaseDate,
                            Genre = Enum.GetName(typeof(Genre), g.Genre.GetHashCode()),
                            DeveloperName = g.Developer.DeveloperName,
                            Platforms = g.Platforms.ToString()
                        }
                    );

                return query.ToList();
            }
        }

        public bool UpdateGame(GameEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var platformQuery =
                    ctx.Platforms
                    .Where(p => model.PlatformNames.Contains(p.PlatformName))
                    .Select(
                        p =>
                        new Platform
                        {
                            PlatformID = p.PlatformID,
                            Brand = p.Brand,
                            PlatformName = p.PlatformName,
                            ReleaseDate = p.ReleaseDate
                        }
                    );

                var devEntity =
                    ctx.Developers
                    .Single(d => d.DeveloperName.ToLower() == model.DeveloperName.ToLower());

                var entity =
                    ctx.Games
                    .Find(model.GameID);

                entity.Title = model.Title;
                entity.ReleaseDate = model.ReleaseDate;
                entity.Genre = model.Genre;
                entity.FirstSubgenre = model.FirstSubgenre;
                entity.SecondSubgenre = model.SecondSubgenre;
                entity.ThirdSubgenre = model.ThirdSubgenre;
                entity.Platforms = platformQuery.ToList();
                entity.DeveloperID = devEntity.DeveloperID;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteGame(int gameID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Games.Find(gameID);

                ctx.Games.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
