using Microsoft.AspNetCore.Mvc;
using Project2.Objects.Interfaces;
using Project2.Objects.Models;
using Project2.ViewMoldels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IGetProducts _product;
        public ProductsController(IGetProducts iproduct)
        {
            _product = iproduct;
        }
        [Route ("Products/Page")]
        [Route ("Products/Page/{type}")]
        public ViewResult Page(string type)
        {
            IEnumerable<Products> product = null;
            if (string.IsNullOrEmpty(type))
            {
                product = _product.IProducts;
            } else if (type.Equals("Овощи", StringComparison.OrdinalIgnoreCase))
            {
                product = _product.IProducts.Where(p => p.Types.TypesName.Equals("Овощи"));
            }
            else if (type.Equals("Фрукты", StringComparison.OrdinalIgnoreCase))
            {
                product = _product.IProducts.Where(p => p.Types.TypesName.Equals("Фрукты"));
            }
            else if (type.Equals("Ягоды", StringComparison.OrdinalIgnoreCase))
            {
                product = _product.IProducts.Where(p => p.Types.TypesName.Equals("Ягоды"));
            }
            else if (type.Equals("Мясо", StringComparison.OrdinalIgnoreCase))
            {
                product = _product.IProducts.Where(p => p.Types.TypesName.Equals("Мясо"));
            }
            ProductViewModel pvm = new ProductViewModel
            {
                getProducts = product,
                currentTypeLoccation = type,
            };
            return View(pvm);
        }
    }
}
