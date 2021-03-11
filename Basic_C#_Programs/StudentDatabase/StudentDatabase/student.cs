using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace StudentDatabase
{
    class student
    {
        public string FirstName { get; set; }
        public virtual List<PostStudent> PostStudents{ get; set;}
    }

    public class PostStudent: DbStudent
    {
        public DbSet<PostStudent> PostStudents { get; set; }
    }

    public class DbStudent
    {
    }
}
