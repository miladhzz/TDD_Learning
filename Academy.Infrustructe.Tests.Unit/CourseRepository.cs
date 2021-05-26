using Academy.Domain;
using System;
using System.Collections.Generic;

namespace Academy.Infrustructe.Tests.Unit
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
    }
}