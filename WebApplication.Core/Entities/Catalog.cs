using System.Collections.Generic;

namespace WebApplication.Core.Entities
{
    public class Catalog : BaseEntity<string>
    {
        public Catalog() => NestedCatalogs = new List<Catalog>();

        public string Name { get; set; }
        public string FriendlyUrl { get; set; }

        public string HeadCatalogId { get; set; }
        public virtual Catalog HeadCatalog { get; set; }

        public virtual ICollection<Catalog> NestedCatalogs { get; set; }

    }
}
