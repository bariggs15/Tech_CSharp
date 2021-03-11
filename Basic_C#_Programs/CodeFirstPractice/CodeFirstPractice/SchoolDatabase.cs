using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CodeFirstPractice
{
    public class SchoolDatabase : DbContext 
    {
        public SchoolDatabase() : base("SchoolDB-CodeFirstPractice")
        {
            Database.SetInitializer<SchoolDatabase>(new SchoolDatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentDemo());
        }
        public DbSet<Student> students { get; set; }

        private class SchoolDatabaseInitializer : IDatabaseInitializer<SchoolDatabase>
        {
            public void InitializeDatabase(SchoolDatabase context)
            {
                throw new NotImplementedException();
            }
        }
    }
}
