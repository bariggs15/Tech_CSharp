using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class ExceptionEntity
    {
        public int ID { get; set; }
        public string  ExceptionType{ get; set; }
        public string  ExceptionMessage { get; set; }
        public DateTime TimStamp { get; set; }
    }
}
