using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department () { Id = 1, Name = "Eletronics" });
            list.Add(new Department () { Id = 2, Name = "Fashion" });
            list.Add(new Department () { Id = 3, Name = "Sports" });
            list.Add(new Department () { Id = 4, Name = "Camping" });
            list.Add(new Department () { Id = 5, Name = "Mountain" });
            list.Add(new Department () { Id = 6, Name = "Swimming" });
            list.Add(new Department () { Id = 7, Name = "Soccer" });
            list.Add(new Department () { Id = 8, Name = "BasketBall" });
            
            
            return View(list);
        }
    }
}