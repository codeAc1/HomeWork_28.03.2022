using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mentor.Models
{
    public class Course
    {
        public int Id { get; set; }
        public Nullable<int>TrainerId { get; set; }
        public Nullable<int>CategoryId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int AvailableSeats { get; set; }
        public TimeSpan StartHour { get; set; }
        public TimeSpan EndtHour { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Descrtion { get; set; }
        

        public Trainer Trainer { get; set; }
        public Category Category { get; set; }
    }
}
