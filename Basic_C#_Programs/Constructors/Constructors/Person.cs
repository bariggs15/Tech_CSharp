using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Person
    {
        public string name1;
        public int id;
        

        public Person (string name1 = "Austin" , int id = 5)
        {
            this.name1 = name1;
            this.id = id;
        }
    }
}
