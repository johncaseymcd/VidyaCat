using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat.Data;
using VidyaCat.Models.DeveloperModels;

namespace VidyaCat.Services
{
    public class DeveloperService
    {
        private readonly Guid _userID;

        public DeveloperService(Guid userID)
        {
            _userID = userID;
        }

        public bool CreateDeveloper(DeveloperCreate model)
        {
            var entity =
                new Developer
                {
                    DeveloperName = model.DeveloperName,
                    Region = model.Region,
                    IsActive = model.IsActive,
                    IsMajor = model.IsMajor
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Developers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<DeveloperListItem> GetDevelopers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Developers
                    .Select(
                        d =>
                        new DeveloperListItem
                        {
                            DeveloperID = d.DeveloperID,
                            DeveloperName = d.DeveloperName,
                            Region = d.Region,
                            IsActive = d.IsActive
                        }
                    );

                return query.ToList();
            }
        }

        public DeveloperDetail GetDeveloperByID(int devID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Developers
                    .Find(devID);

                var games =
                    ctx.Games
                    .Where(g => g.DeveloperID == devID)
                    .Select(
                        g =>
                        g.Title
                    );

                return new DeveloperDetail
                {
                    DeveloperID = entity.DeveloperID,
                    DeveloperName = entity.DeveloperName,
                    Region = entity.Region,
                    IsActive = entity.IsActive,
                    IsMajor = entity.IsMajor,
                    GamesDeveloped = games.ToList()
                };
            }
        }

        public IEnumerable<DeveloperListItem> GetDevelopersByRegion(Region region)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Developers
                    .Where(d => d.Region == region)
                    .Select(
                        d =>
                        new DeveloperListItem
                        {
                            DeveloperID = d.DeveloperID,
                            DeveloperName = d.DeveloperName,
                            Region = d.Region,
                            IsActive = d.IsActive
                        }
                    );

                return query.ToList();
            }
        }

        public IEnumerable<DeveloperListItem> GetDevelopersByStatus(string status)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Developers
                    .Where(g => g.Status == status)
                    .Select(
                        d =>
                        new DeveloperListItem
                        {
                            DeveloperID = d.DeveloperID,
                            DeveloperName = d.DeveloperName,
                            Region = d.Region,
                            IsActive = d.IsActive
                        }
                    );

                return query.ToList();
            }
        }

        public IEnumerable<DeveloperListItem> GetDevelopersByType(string type)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Developers
                    .Where(d => d.Type == type)
                    .Select(
                        d =>
                        new DeveloperListItem
                        {
                            DeveloperID = d.DeveloperID,
                            DeveloperName = d.DeveloperName,
                            Region = d.Region,
                            IsActive = d.IsActive
                        }
                    );

                return query.ToList();
            }
        }

        public bool UpdateDeveloper(DeveloperEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Developers
                    .Find(model.DeveloperID);

                entity.DeveloperName = model.DeveloperName;
                entity.Region = model.Region;
                entity.IsActive = model.IsActive;
                entity.IsMajor = model.IsMajor;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteDeveloper(int devID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Developers.Find(devID);

                ctx.Developers.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
