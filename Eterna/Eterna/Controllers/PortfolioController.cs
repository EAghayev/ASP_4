using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly DataContext _context;

        public PortfolioController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            PortfolioViewModel portfolioVM = new PortfolioViewModel
            {
                Portfolios = _context.Portfolios.Include(x=>x.Category).Include(x=>x.PortfolioImages).ToList(),
                Categories =  _context.Categories.ToList()
            };

            return View(portfolioVM);
        }

        public IActionResult Detail(int id)
        {
            Portfolio portfolio = _context.Portfolios.Include(x=>x.Category).Include(x=>x.PortfolioImages).FirstOrDefault(x => x.Id == id);

            return View(portfolio);
        }

        public IActionResult Test()
        {
            var portfolios = _context.Portfolios.Where(x => x.CategoryId == 1).ToList();

            //PortfolioImage portfolioImage = _context.PortfolioImages.Include("Portfolio.Category").FirstOrDefault();
            PortfolioImage portfolioImage = _context.PortfolioImages.Include(x => x.Portfolio).ThenInclude(p => p.Category).FirstOrDefault();

            return Json(portfolioImage);
        }
    }
}
