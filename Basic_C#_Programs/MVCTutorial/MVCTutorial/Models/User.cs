using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
    public class User
    {
        public int Id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public int age { get; set; }
    }
}