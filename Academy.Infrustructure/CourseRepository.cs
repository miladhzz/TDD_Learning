using Academy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy.Infrustructure
{
    public class CourseRepository
    {
        public CourseRepository()
        {
            Courses = new List<Course>()
            {
                new Course(10, "Django", 2000, 20)
            };
        }

        public List<Course> Courses { get; set; }

        public void Create(Course course)
        {
            Courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return Courses;
        }

        public Course GetBy(int id)
        {
            return Courses.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            var course = GetBy(id);
            Courses.Remove(course);
        }
    }
}