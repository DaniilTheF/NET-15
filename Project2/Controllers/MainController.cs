using Microsoft.AspNetCore.Mvc;
using Project2.Objects.Interfaces;
using Project2.ViewMoldels;

namespace Project2.Controllers
{
    public class MainController : Controller
    {
        private IGetProducts getProducts;

        public MainController(IGetProducts getProducts)
        {
            this.getProducts = getProducts;
        }

        public ViewResult MainPage()
        {
            var products = new MainViewModel
            {
                Products = getProducts.IFavProducts
            };
            return View(products);
        }
    }
}
