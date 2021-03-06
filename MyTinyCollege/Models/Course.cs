﻿using System.Collections;
using System.Collections.Generic;

namespace MyTinyCollege.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public int DepartmentID { get; set; }//Fk to department

        //Navigation properties
        //1 Course to many enrollments
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        //1 course to many instructors 
        public virtual ICollection<Instructor> Instructors { get; set; }

        //course belongs to a department
        public virtual Department Department { get; set; }

        //Combine the CourseID and title in property
        public string CourseIdTitle
        {
            get
            {
                return CourseID + ": " + Title;
            }
        }
    }
}