using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Constructors
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public Person(string name) : this(name, 1)
        {

        }

    }
}


