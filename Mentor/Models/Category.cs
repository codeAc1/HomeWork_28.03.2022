using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mentor.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }

        public IEnumerable<Trainer> Trainers { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
