using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApplication.Core.Models
{
    public abstract class CatalogBaseViewModel : BaseModel<string>
    {
        public string Name { get; set; }
        public string HeadCatalogId { get; set; }

    }
    public class CatalogGetFullViewModel : CatalogBaseViewModel
    {
        public virtual CatalogGetMinViewModel HeadCatalog { get; set; }
        public List<CatalogGetMinViewModel> NestedCatalogs { get; set; }
    }
    public class CatalogGetMinViewModel : CatalogBaseViewModel
    {
    }
    public class CatalogAddViewModel : CatalogBaseViewModel
    {
    }

}
