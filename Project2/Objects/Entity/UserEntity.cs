using Project2.Objects.DB;
using Project2.Objects.Interfaces;
using Project2.Objects.Models;
using Project2.ViewMoldels;
using System.Collections.Generic;
using System.Linq;

namespace Project2.Objects.Entity
{
    public class UserEntity : IGetUser
    {

        ProductsBasket productsBasket;
        private readonly DataBase DB;

        public IEnumerable<User> users { get; set; }
        public UserEntity( ProductsBasket productsBasket, DataBase DB)
        {
            this.productsBasket = productsBasket;
            this.DB = DB;

        }
        public void AddToDB(User user)
        {
            this.DB.User.Add(new User
            {
                FIO = user.FIO,
                phoneN = user.phoneN,
                adress = user.adress,
                login = user.login,
                password = user.password,
            });
            DB.SaveChanges();
        }

        public IEnumerable<User> GetUser(User user)
        {
            return DB.User.Where(u => u.login == user.login).ToList();
        }

        public void CreateOrder(User user)
        {
            var products = productsBasket.list;
            foreach (ItemProductsBasket items in products)
            {
                Order order = new Order()
                {
                    OrderId = user.Id,
                    Products = items.Products,
                    User = user,

                };
                DB.Order.Add(order);
            }
            DB.SaveChanges();
        }
    }
}
