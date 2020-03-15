using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UdemyWeb.Models
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext _appDbContext;

        public CourseRepository(DataContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Course> Courses
        {
            get { return _appDbContext.Courses.Include(c => c.Category); }
        }

        public Course GetCourseById(int CourseId)
        {
            return _appDbContext.Courses.FirstOrDefault(p => p.CourseId == CourseId);
        }

        public IEnumerable<Course> CourseOfTheWeek
        {
            get { return _appDbContext.Courses.Include(c => c.Category).Where(p => p.CourseOfTheWeek); }
        }
    }
}
