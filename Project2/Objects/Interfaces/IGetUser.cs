using Project2.Objects.Models;
using System;
using System.Collections.Generic;

namespace Project2.Objects.Interfaces
{
    public interface IGetUser
    {
        public void AddToDB(User user);
        public void CreateOrder(User user);
        public IEnumerable<User> GetUser(User user);

        public IEnumerable<User> users { get; set; }
    }
}
