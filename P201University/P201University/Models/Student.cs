using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P201University.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:20)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 20)]
        public string Surname { get; set; }
        public int? Age { get; set; }
        [Required]
        [StringLength(maximumLength:10)]
        public string GroupNo { get; set; }
        public int Point { get; set; }
    }
}
