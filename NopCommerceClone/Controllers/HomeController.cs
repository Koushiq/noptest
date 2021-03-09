using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NopCommerceClone.Models;
using NopCommerceClone.Web.Models;
using NopCommerceClone.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NopCommerceClone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProductRepository _productRepository = new ProductRepository();
        private CatelogRepository _catelogRepository = new CatelogRepository();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.Products = _productRepository.GetAll();
            foreach (var item in productViewModel.Products)
            {
                item.Catelog = _catelogRepository.GetId(item.CatelogID);
            }

            return View(productViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
