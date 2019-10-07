using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication.Core.Entities;

namespace WebApplication.Core.Helpers.Core
{
    public static class CatalogExtension
    {
        public static void AddNested(this Catalog catalog, params Catalog[] catalogs)
        {
            var collection = new List<Catalog>();

            collection.AddRange(catalogs);
            catalog.NestedCatalogs = collection;
        }

        public static string TryGetFriendlyUrl(this Catalog catalog)
        {
            string          friendlyUrl;
            Catalog         headCatalog;
            StringBuilder   stringBuilder;

            if (catalog.FriendlyUrl.Exist())
                return catalog.FriendlyUrl;

            stringBuilder = new StringBuilder();
            headCatalog = catalog.HeadCatalog;

            if (headCatalog.Exist() &&
                headCatalog.FriendlyUrl.IsEmpty())
            {
                return null;
            }
            else if (!headCatalog.Exist())
            {
                friendlyUrl = catalog.Name.Replace(" ", "");
            }
            else
            {
                friendlyUrl = stringBuilder
                    .Append(headCatalog.FriendlyUrl.Replace(" ", ""))
                    .Append('/')
                    .Append(catalog.Name.Replace(" ", ""))
                    .ToString();
            }

            return catalog.FriendlyUrl = friendlyUrl;
        }

        public static IEnumerable<string> TryGetFriendlyUrl(this IEnumerable<Catalog> catalogs)
        {
            foreach (var catalog in catalogs)
            {
                catalog.TryGetFriendlyUrl();
            }

            return catalogs.Select(c => c.FriendlyUrl);
        }
    }
}
