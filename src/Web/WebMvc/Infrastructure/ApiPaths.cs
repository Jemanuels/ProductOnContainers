using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOnContainers.Web.WebMvc.Infrastructure
{
    /// <summary>
    /// This calls will holds all the static class which will provide us access to all the api paths available
    /// </summary>
    public class ApiPaths
    {
        public static class Catalog
        {
            /// <summary>
            /// Get all the catalog items
            /// </summary>
            /// <param name="baseUri">The base url for building the api uri</param>
            /// <param name="page"> The amount of page to be returned</param>
            /// <param name="take">The page size for the amount of items on a page</param>
            /// <param name="brand">The brands to, return only provided brand</param>
            /// <param name="type">The type of catalogs</param>
            /// <returns>The uri for gettting all the catalog items</returns>
            public static string GetAllCatalogItems(string baseUri, int page, int take, int? brand, int? type)
            {
                var filterQs = "";

                if (brand.HasValue || type.HasValue)
                {
                    var brandQs = (brand.HasValue) ? brand.Value.ToString() : "null";
                    var typeQs = (type.HasValue) ? type.Value.ToString() : "null";
                    filterQs = $"/type/{typeQs}/brand/{brandQs}";
                }

                return $"{baseUri}items{filterQs}?pageIndex={page}&pageSize={take}";
            }

            /// <summary>
            /// Get one catalog item
            /// </summary>
            /// <param name="baseUri"></param>
            /// <param name="id"></param>
            /// <returns></returns>
            public static string GetCatalogItem(string baseUri, int id)
            {

                return $"{baseUri}/items/{id}";
            }

            /// <summary>
            /// Get all the brands
            /// </summary>
            /// <param name="baseUri"></param>
            /// <returns></returns>
            public static string GetAllBrands(string baseUri)
            {
                return $"{baseUri}catalogBrands";
            }

            /// <summary>
            /// Get all the types available
            /// </summary>
            /// <param name="baseUri"></param>
            /// <returns></returns>
            public static string GetAllTypes(string baseUri)
            {
                return $"{baseUri}catalogTypes";
            }
        }
    }
}
