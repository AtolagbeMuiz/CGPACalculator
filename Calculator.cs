using System;
using System.Collections.Generic;
public class Calculator
{
    // public int unit { get; set; }
    // public double score { get; set; }

    //Repository repo = new Repository();

    double A,B,C,D,E,F = 0;
    double totalUnits = 0;
    public double calculateCGPA(List<Course> listofCourses)
    {
       //This Foreach Loop iterates through the courses in the list
        foreach(var course in listofCourses)
        {
            totalUnits += course.NumberOfUnits;

            //This For Loop iterates th
            //for(int i =0; i < listofCourses.Count; i++)
            //foreach(var )
            //{
                if((course.CourseScore >= 70) && (course.CourseScore <= 100))
                {
                    A += (5 * course.NumberOfUnits);
                }
                else if((course.CourseScore >= 60) && (course.CourseScore < 70 ))
                {
                    B += (4 * course.NumberOfUnits);
                }
                else if((course.CourseScore >= 50) && (course.CourseScore < 60 ))
                {
                    C += (3 * course.NumberOfUnits);
                }
                else if((course.CourseScore >= 40) && (course.CourseScore < 50 ))
                {
                    D += (2 * course.NumberOfUnits);
                }
                else if((course.CourseScore >= 30) && (course.CourseScore < 40 ))
                {
                    E += (1 * course.NumberOfUnits);
                }
                else 
                {
                    F += (0 * course.NumberOfUnits);
                }
           // }
        }

        double calculatedCGPA = (A + B + C + D + E + F) / totalUnits;
        var roundedCGPA = Math.Round(calculatedCGPA, 2);
        return roundedCGPA;


    }
}