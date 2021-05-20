using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Domain
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Section(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
