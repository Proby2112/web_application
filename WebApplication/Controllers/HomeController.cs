using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using WebApplication.Core.Helpers.Core;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Services;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        ICatalogService _service;

        public HomeController(ICatalogService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Catalogs()
        {
            RouteValueDictionary routeValues = RouteData.Values;

            if (!routeValues.TryGetValue("friendlyUrl", out object friendlyUrl))
                return StatusCode(404);

            if (friendlyUrl.Exist())
            {
                var catalog = await _service.GetByUrlAsync(friendlyUrl as string);
                return !catalog.Exist() ? StatusCode(404) : (IActionResult)View("SingleCatalog", catalog);
            }
            else
            {
                var catalogs = await _service.GetAllAsync();
                return View(catalogs);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
