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
        public const string name1 = "Bruce";
        public int id;
        public Person(string Name, int ID1)
        {
            string name1 = Name;
            var id = ID1;
        }
              
    }
}


