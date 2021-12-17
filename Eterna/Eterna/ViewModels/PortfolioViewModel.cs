using Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.ViewModels
{
    public class PortfolioViewModel
    {
        public List<Portfolio> Portfolios { get; set; }
        public List<Category> Categories { get; set; }
    }
}
