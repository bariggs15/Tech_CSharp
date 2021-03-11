using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstPractice
{
    class StudentDemo : EntityTypeConfiguration<Student>
    {
        public StudentDemo()
        {
            this.Property(x => x.FirstName).IsRequired().HasMaxLength(25);
        }
    }
}
