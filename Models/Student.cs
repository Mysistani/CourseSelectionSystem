using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Models
{
    class Student :  Person
    {
        private readonly List<Enrollment> _enrollments =
            new List<Enrollment>();

    public IReadOnlyList<Enrollment> Enrollments
        { get { return _enrollments; } }

    public Student(string name , int age ): base(name, age)
        { }
    public void AddCourse (Course course)
        {
            Enrollment? existingEnrollment =
               FindEnrollment(course.Name);

            if (existingEnrollment is not null)
            {
                throw new InvalidOperationException(
                    $"dars «{course.Name}» ghabla entekhab shode .");
            }

            Enrollment enrollment = new Enrollment(course);
            _enrollments.Add(enrollment);
        }
        public void RecordMidtermGrade(
    string courseName,
    float grade)
        {
            Enrollment? enrollment = FindEnrollment(courseName);

            if (enrollment is null)
            {
                throw new InvalidOperationException(
                    $"dars «{courseName}» not found");
            }

            enrollment.RecordMidtermGrade(grade);
        }

        public void RecordFinalGrade(
            string courseName,
            float grade)
        {
            Enrollment? enrollment = FindEnrollment(courseName);

            if (enrollment is null)
            {
                throw new InvalidOperationException(
                    $"درس «{courseName}» پیدا نشد.");
            }

            enrollment.RecordFinalGrade(grade);
        }

        private Enrollment? FindEnrollment(string courseName)
        {
            foreach (Enrollment enrollment in _enrollments)
            {
                bool namesAreEqual = string.Equals(
                    enrollment.Course.Name,
                    courseName,
                    StringComparison.OrdinalIgnoreCase);

                if (namesAreEqual)
                {
                    return enrollment;
                }
            }

            return null;
        }
    }

}
