﻿namespace MyTinyCollege.Models
{
    //Grade enum
    public enum Grade
    {
        A,B,C,D,F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }//PK

        public int CourseID { get; set; }//FK to course

        public int StudentID { get; set; }//Fk to student

        public Grade? Grade { get; set; }//In this case means optional
        public virtual Student student { get; set; }//Many enrollments to 1 student
        public virtual Course course { get; set; }//Many enrollments to 1 course

    }
}