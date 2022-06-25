using ConsoleTransaction_Sample.Data;
using ConsoleTransaction_Sample.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleTransaction_Sample
{
    public class Requests
    {
        private SchoolContext _context;

        public Requests(SchoolContext context)
        {
            _context = context;
        }

        public List<Course> GetList()
        {
            var courses = this._context.Courses.Include(c => c.Students).ToList();
            return courses;
        }
    }
}