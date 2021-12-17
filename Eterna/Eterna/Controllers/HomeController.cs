using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {

        private DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //List<Slider> sliders = new List<Slider>
            //{
            //    new Slider{Id = 1,Title1 = "Welcome to",Title2 = "P201",BgImage = "slide-1.jpg",RedirectUrl = "https://github.com",Desc="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto."},
            //    new Slider{Id = 12,Title1 = "Goodbye from",Title2 = "P201",BgImage = "slide-2.jpg",RedirectUrl = "https://code.edu.az",Desc="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto."},
            //    new Slider{Id = 13,Title1 = "Welcome to",Title2 = "Hesen's Kesirs",BgImage = "slide-3.jpg",RedirectUrl = "http://aztu.edu.az/azp/facult/exam/az/main/main.jsp",Desc="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto."},
            //};

            //List<Feature> features = new List<Feature>
            //{
            //    new Feature{Id = 4,Icon="<i class=\"bi bi-binoculars\"></i>",Title = "Programming",Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            //    new Feature{Id = 5,Icon="<i class=\"bi bi-card-checklist\"></i>",Title = "Design",Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            //    new Feature{Id = 6,Icon="<i class=\"bi bi-bar-chart\"></i>",Title = "System",Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            //};

            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _context.Sliders.ToList(),
                Features = _context.Features.ToList()
            };

            return View(homeVM);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }
    }
}
