using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Program 
    {

        static void Main(string[] args)
        {
            const int id1 = 200;   
            var person1 = new Person("Bruce", id1);

            Person person2 = new Person("Austin");

            Console.WriteLine("Person 1 name {0} and person 1 ID {1} \nPerson 2 name {2} and person 2 ID{3} ", person1.Name, person1.Id, person2.Name, person2.Id);
            Console.ReadLine();

        } 
    }
}
