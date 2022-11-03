using Microsoft.AspNetCore.Mvc;
using Project2.Objects.Entity;
using Project2.Objects.Interfaces;
using Project2.ViewMoldels;
using System.Linq;

namespace Project2.Controllers
{
    public class ProductsBasketController : Controller
    {
        private readonly IGetProducts getProducts;
        private readonly ProductsBasket productsBasket;

        public ProductsBasketController(IGetProducts getProducts, ProductsBasket productsBasket)
        {
            this.getProducts = getProducts;
            this.productsBasket = productsBasket;
        }

        public ViewResult Basket()
        {
            var products = productsBasket.GetBasket();
             productsBasket.list = products;
           
            return View(productsBasket);
        }

        public RedirectToActionResult RedirectToNewBasket(int productId)
        {
            
                productsBasket.RemoveFromBasked(productId);
           
            return RedirectToAction("Basket");
        }

        public RedirectToActionResult RedirectToBasket(int productId)
        {
            var product = getProducts.IProducts.FirstOrDefault(i => i.Id == productId);
            if (product != null)
            {
                productsBasket.AddToBasked(product);
            }
            return RedirectToAction("Basket");
        }
    }
}
