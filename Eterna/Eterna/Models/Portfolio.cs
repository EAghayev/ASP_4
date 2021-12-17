using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [StringLength(maximumLength:20)]
        public string CartTitle { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        [StringLength(maximumLength: 500)]
        public string Desc { get; set; }
        [StringLength(maximumLength: 250)]
        public string ProjectUrl { get; set; }
        [StringLength(maximumLength: 50)]
        public string Client { get; set; }
        public DateTime Date { get; set; }

        public Category Category { get; set; }
        public List<PortfolioImage> PortfolioImages { get; set; }
    }
}
