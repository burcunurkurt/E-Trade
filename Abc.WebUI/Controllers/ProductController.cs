using Abc.Northwind.Business.Abstract;
using Abc.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;

        }
        public ActionResult Index()
        {

            var products =_productService.GetAll();
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products

            };
            return View(model);
        }
    }
}
