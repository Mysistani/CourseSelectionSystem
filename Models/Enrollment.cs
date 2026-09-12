using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Models
{
    public class Enrollment
        // in class namayande entekhabe yek dars tavasote daneshjo ast

    {
        public Course course { get;}



        public double? MidtermGrade { get; private set; }
        public double? FinalGrade { get; private set; }

        public Enrollment(Course course)
        {
            Course = course;
        }

        public void RecordMidtermGrade(double grade)
        {
            ValidateGrade(grade);
            MidtermGrade = grade;
        }

        public void RecordFinalGrade(double grade)
        {
            ValidateGrade(grade);
            FinalGrade = grade;
        }

        private static void ValidateGrade(double grade)
        {
            if (grade < 0 || grade > 20)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(grade),
                    "نمره باید بین صفر تا ۲۰ باشد.");
            }
        }
    }
}

