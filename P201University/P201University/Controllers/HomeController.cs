using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using P201University.Models;
using P201University.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace P201University.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Students = _context.Students.ToList()
            };

            return View(homeVM);
        }
    }
}
