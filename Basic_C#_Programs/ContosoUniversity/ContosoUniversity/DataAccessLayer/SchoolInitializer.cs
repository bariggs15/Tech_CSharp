using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ContosoUniversity.DataAccessLayer
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        private object students;

        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
           {
               new Student{FirstMidName ="Austin", LastName ="Riggs", EntrollmentDate = DateTime.Parse("2006-10-10")},
               new Student{FirstMidName ="Bradleigh", LastName ="Riggs", EntrollmentDate = DateTime.Parse("2003-10-10")},
               new Student{FirstMidName ="Denita", LastName ="Hancock", EntrollmentDate = DateTime.Parse("1980-10-10")},
           };

            students.ForEach (s => context.Students.Add(s)) ;
            context.SaveChanges();
            var courses = new List<Course>
            {
                new Course{CourseID =1005, Title ="Chemistry", Credits = 3},
                new Course{CourseID =1205, Title ="Macro", Credits = 5},
                new Course{CourseID =3000, Title ="Calculus", Credits = 3},
            };
            courses.ForEach (s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID =1, CourseID =3000, Grade=Grade.A},
            new Enrollment{StudentID =2, CourseID =1205, Grade=Grade.B},
            new Enrollment{StudentID =3, CourseID =1005, Grade=Grade.D},
            new Enrollment{StudentID =1, CourseID =1005, Grade=Grade.A},
            new Enrollment{StudentID =2, CourseID =3000 },
            };
            enrollments.ForEach(x => context.Enrollments.Add(x));
            context.SaveChanges();

        }   
    }
    
}