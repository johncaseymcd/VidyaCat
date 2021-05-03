using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat.Data;
using VidyaCat.Models.PlatformModels;

namespace VidyaCat.Services
{
    public class PlatformService
    {
        private readonly Guid _userID;

        public PlatformService(Guid userID)
        {
            _userID = userID;
        }

        public bool CreatePlatform(PlatformCreate model)
        {
            var entity =
                new Platform
                {
                    Brand = model.Brand,
                    PlatformName = model.PlatformName,
                    ReleaseDate = model.ReleaseDate
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Platforms.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PlatformListItem> GetPlatforms()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Platforms
                    .Select(
                        p =>
                        new PlatformListItem
                        {
                            PlatformID = p.PlatformID,
                            Brand = p.Brand,
                            PlatformName = p.PlatformName,
                            ReleaseDate = p.ReleaseDate
                        }
                    );

                return query.ToList();
            }
        }

        public PlatformDetail GetPlatformByID(int platID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Platforms.Find(platID);

                var games =
                    ctx.Games
                    .Where(g => g.Platforms.Contains(entity.PlatformName))
                    .Select(g => g.Title);

                return new PlatformDetail
                {
                    PlatformID = entity.PlatformID,
                    Brand = entity.Brand,
                    PlatformName = entity.PlatformName,
                    ReleaseDate = entity.ReleaseDate,
                    GamesOnPlatform = games.ToList().Count
                };
            }
        }

        public IEnumerable<PlatformListItem> GetPlatformsByYear(int year)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Platforms
                    .Where(p => p.ReleaseDate.Year == year)
                    .Select(
                        p =>
                        new PlatformListItem
                        {
                            PlatformID = p.PlatformID,
                            Brand = p.Brand,
                            PlatformName = p.PlatformName,
                            ReleaseDate = p.ReleaseDate
                        }
                    );

                return query.ToList();
            }
        }

        public IEnumerable<PlatformListItem> GetPlatformsByBrand(Brand brand)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Platforms
                    .Where(p => p.Brand == brand)
                    .Select(
                        p =>
                        new PlatformListItem
                        {
                            PlatformID = p.PlatformID,
                            Brand = p.Brand,
                            PlatformName = p.PlatformName,
                            ReleaseDate = p.ReleaseDate
                        }
                    );

                return query.ToList();
            }
        }

        public IEnumerable<PlatformListItem> GetPlatformsByStatus(string status)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Platforms
                    .Where(p => p.Status == status)
                    .Select(
                        p =>
                        new PlatformListItem
                        {
                            PlatformID = p.PlatformID,
                            Brand = p.Brand,
                            PlatformName = p.PlatformName,
                            ReleaseDate = p.ReleaseDate
                        }
                    );

                return query.ToList();
            }
        }

        public bool UpdatePlatform(PlatformEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Platforms.Find(model.PlatformID);

                entity.Brand = model.Brand;
                entity.PlatformName = model.PlatformName;
                entity.ReleaseDate = model.ReleaseDate;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeletePlatform(int platID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Platforms.Find(platID);

                ctx.Platforms.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
