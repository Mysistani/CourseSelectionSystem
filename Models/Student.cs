using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Models
{
    class Student :  Person
    {
        private readonly List<Enrollment> _enrollments =
            new List<Enrollment>();
    public IReadOnlyList<Enrollment> Enrollments { get { return _enrollments; } }
    public Student(string name , int age ): base(name, age)
        { }
    public void AddCourse (Course course)
        {
            Enrollment enrollment = new Enrollment(course);
            _enrollments.Add(enrollment);
        }
    }

}
