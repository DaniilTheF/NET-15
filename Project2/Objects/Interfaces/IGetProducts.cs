using Project2.Objects.Models;
using System.Collections.Generic;

namespace Project2.Objects.Interfaces
{
    public interface IGetProducts
    {
        IEnumerable<Products> IProducts { get; }
        IEnumerable<Products> IFavProducts { get; }

    }
}
