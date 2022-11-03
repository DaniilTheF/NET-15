using Microsoft.EntityFrameworkCore;
using Project2.Objects.DB;
using Project2.Objects.Interfaces;
using Project2.Objects.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project2.Objects.Entity
{
    public class ProductEntity : IGetProducts
    {
        private readonly DataBase DB;

        public ProductEntity(DataBase DB)
        {
            this.DB = DB;
        }

        public IEnumerable<Products> IProducts => DB.Products.Include(c => c.Types);

        public IEnumerable<Products> IFavProducts => DB.Products.Where(p => p.OnMain).Include(c => c.Types);

    }
        
}
