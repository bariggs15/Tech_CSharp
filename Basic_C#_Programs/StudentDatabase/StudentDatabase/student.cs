using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace StudentDatabase
{
    public class student
    {
        public string FirstName { get; set; }
        public int Id { get; set; } 
    }

    public class StudentContext: DbContext
    {
        public DbSet<student> students { get; set; }
    }

   
}
