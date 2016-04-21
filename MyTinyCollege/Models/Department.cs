using System;
using System.Collections;
using System.Collections.Generic;

namespace MyTinyCollege.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }//Pk
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? InstructorID { get; set; }//Fk to instructor
        //============== Navigation properties =================
        public virtual Instructor Adminstrator { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}