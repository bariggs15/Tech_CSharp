using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + this.firstName + this.lastName);
        }

        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }

    }
}
