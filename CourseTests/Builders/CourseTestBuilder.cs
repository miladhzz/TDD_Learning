using Academy.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseTests.Builders
{
    public class CourseTestBuilder
    {
        private int _id = 0;
        private string _name = "milad";
        private double _price = 1000;
        private int _age = 0;
        //private List<Section> _sections;

        public CourseTestBuilder WithName(string name)
        {
            this._name = name;
            return this;
        }

        public CourseTestBuilder WithPrice(double price)
        {
            this._price = price;
            return this;
        }

        public Course Build()
        {
            return new Course(_id, _name, _price, _age);
        }

        public CourseTestBuilder WithId(int id)
        {
            this._id = id;
            return this;
        }
    }
}
