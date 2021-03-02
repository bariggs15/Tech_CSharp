using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {

        
        
        static void Main(string[] args)
        {
            const string dad = "Bruce";
            var id = 200;

            //Person boss = new Person(dad);

            //Person bossid = new Person(id);

            Person person = new Person(dad, id); 
            ;
            Console.ReadLine();

        } 
        
      
        
    }
}
