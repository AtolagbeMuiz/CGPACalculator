using System;
using CGPACalculator;
using System.Text;
using System.Collections.Generic;
public class Repository
{
    private List<Course> CourseTable;

        public Repository()
        {
            this.CourseTable = new List<Course>();
        }

        public void addCourse(Course course)
        {
            this.CourseTable.Add(course);
        }

         public List<Course> getAllCourses()
        {
            return CourseTable;
        }
}