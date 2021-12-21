using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppDBList.Models;

namespace WebAppDBList.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            List<Customer> customers =new List<Customer>
            {
                new Customer()
                {
                    Id = 1,
                    Name ="Hasan",
                    LastName ="Nuruzade",
                    Age =29,
                    Adress ="Ismayilli"

                },
                new Customer()
                {
                    Id = 2,
                    Name ="Kamal",
                    LastName ="Kamalov",
                    Age =25,
                    Adress ="Masalli"

                },
                new Customer()
                {
                    Id = 3,
                    Name ="Mireli",
                    LastName ="Eliyev",
                    Age =45,
                    Adress ="Gedebey"

                }
            };
            return View(customers);
        }
    }
}
