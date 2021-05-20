using Academy.Domain.Exceptions;
using System;
using System.Collections.Generic;

namespace Academy.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Age { get; set; }
        public List<Section> Sections { get; set; }

        public Course(int id, string name, double price, int age)
        {
            CheckEmptyString(name);
            CheckNegativePrice(price);

            Id = id;
            Name = name;
            Price = price;
            Age = age;
            Sections = new List<Section>();
        }
        private static void CheckEmptyString(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new CourseNameIsEmptyException();
        }

        private static void CheckNegativePrice(double price)
        {
            if (price < 0)
                throw new CoursePriceIsNegativeException();
        }

        public void AddSection(Section section)
        {
            Sections.Add(section);
        }
    }
}
