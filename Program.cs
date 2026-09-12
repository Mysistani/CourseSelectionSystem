using CourseSelectionSystem.Models;

Course databaseCourse = new Course("db", 3);
Student student = new Student("mohammad", 25);

student.AddCourse(databaseCourse);

Enrollment enrollment = student.Enrollments[0];

if (enrollment.MidtermGrade is null)
{
    Console.WriteLine("nomre mianterm sabt nashode.");
}

student.RecordMidtermGrade("db", (float)17.5);

Console.WriteLine(
    $"nomre mianterm: {enrollment.MidtermGrade}");