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

        //method that adds courses to the collection
        public void addCourse(Course course)
        {
            this.CourseTable.Add(course);
        }

        //method that returns the list of courses from the collection
         public List<Course> getAllCourses()
        {
            return CourseTable;
        }
}