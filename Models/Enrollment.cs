using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Models
{
    public class Enrollment
        // in class namayande entekhabe yek dars tavasote daneshjo ast

    {
        public Course Course { get;}



        public float? MidtermGrade { get; private set; }
        public float? FinalGrade { get; private set; }

        public Enrollment(Course course)
        {
            Course = course;
        }

        public void RecordMidtermGrade(float grade)
        {
            ValidateGrade(grade);
            MidtermGrade = grade;
        }

        public void RecordFinalGrade(float grade)
        {
            ValidateGrade(grade);
            FinalGrade = grade;
        }

        private static void ValidateGrade(float grade)
        {
            if (grade < 0 || grade > 20)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(grade),
                    "nomre bayad beyn 0 ta 20 bashe");
            }
        }
    }
}

