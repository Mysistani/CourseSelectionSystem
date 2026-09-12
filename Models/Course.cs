using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace CourseSelectionSystem.Models
{
    public class Course
    {
        // name and units create first in constructor 
        // mifterm and final grade in steps in term extended
        public string Name { get; }
        public int Units {  get; }
        public float MidtermGrade;
        
        public float FinalGrade;

        public Course(string name , int unit)
        {
            Name = name;
            Units = unit;
        }
    }
}
