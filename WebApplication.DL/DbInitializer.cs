using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication.Core.Entities;
using WebApplication.Core.Helpers.Core;

namespace WebApplication.DL
{
    public static class DbInitializer
    {
        static AppDbContext _context;

        public static void Initialize(AppDbContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();       // Create DB if not exist.

            // Add your init methods here
            AddCatalogs();

            _context.SaveChanges();
        }

        private static void AddCatalogs()
        {
            if (_context.Catalogs.Any()) return;

            // Add the new catalogs.
            var digitalImages       = Create("Creating Digital Images");
            var resources           = Create("Resources");
            var evidence            = Create("Evidence");
            var graphicProducts     = Create("Graphic Products");
            var primarySources      = Create("Primary Sources");
            var secondarySources    = Create("Secondary Sources");
            var process             = Create("Process");
            var finalProduct        = Create("Final Product");

            // Link the catalogs.
            digitalImages.AddNested(resources, evidence, graphicProducts);
            resources.AddNested(primarySources, secondarySources);
            graphicProducts.AddNested(process, finalProduct);

            _context.SaveChanges();

            SetUrls();

            Catalog Create(string name)
            {
                var entity = new Catalog {Name = name};
                entity.SetId();

                _context.Entry(entity).State = EntityState.Added;

                return entity;
            }

            void SetUrls()
            {
                var catalogs = _context.Catalogs.ToList();

                while (catalogs.Any(c => c.FriendlyUrl.IsEmpty()))
                {
                    catalogs
                        .Where(c => c.FriendlyUrl.IsEmpty())
                        .TryGetFriendlyUrl();
                }
            }
        }
    }
}
