using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyWeb.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool CourseOfTheWeek { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
