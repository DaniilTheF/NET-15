using Microsoft.AspNetCore.Mvc;
using Project2.Objects.DB;
using Project2.Objects.Entity;
using Project2.Objects.Interfaces;
using Project2.Objects.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project2.Controllers
{
    public class UserController : Controller
    {
        
        private readonly DataBase DB;
        private readonly IGetUser getUser;
        public UserController(DataBase DB, IGetUser getUser)
        {
            this.DB = DB;
            this.getUser = getUser;
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(User user)
        {
            getUser.users = getUser.GetUser(user);
       
            if (getUser.users.Count() == 0)
            {
                if (ModelState.IsValid)
                {
                    getUser.CreateOrder(user);
                    return RedirectToAction("Complete");
                }
            }
               
            return View(user);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Вы успешно прошли регистрацию";
            return View();
        }

    }
}
