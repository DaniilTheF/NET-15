using System.Collections.Generic;
using Project2.Objects.Models;

namespace Project2.ViewMoldels
{
    public class ProductViewModel
    {
        public IEnumerable<Products> getProducts { get; set; }
        public string currentTypeLoccation { get; set; }
    }
}
