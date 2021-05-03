using System;

namespace CGPACalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // a program that calculates gradePoint average 
            // Input -->a series of  course codes,a series of scores for each course code.
            // a gradePointCalculator that calculates the GradePoint of a course given its score
            // some sort of dashboard that prints grade points
            //a menu that prompts the users on what they want to do
            // i can probably use an enum to check my current stage

            //Solution starts here
            Menu menu = new Menu();
            Repository repo = new Repository();
            Calculator calc = new Calculator();
            menu.setCurrentStage(1);

            while(menu.getCurrentStage() == 1)
            {
                Menu.promptUser("What Would you like to Do Today : ?");
                Menu.promptUser("1. Add Courses To DB : ");
                Menu.promptUser("2. Calculate Grade Point Averages Of Courses In Db : ");
                Menu.promptUser("3. Exit");
                var selectedMenuOption = Console.ReadLine();

                switch(selectedMenuOption)
                {
                    case "1" :
                        menu.setCurrentStage(2);
                        break;

                    case "2" :
                        menu.setCurrentStage(3);
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }

                Console.Clear();
            }


            while(menu.getCurrentStage() == 2)
            {
                //  we want to tell the user to add a set of courses and their scores
                //  and then we want to store those courses in some sort of Database/ collection
                //  we need to know how many courses the user is entering a score for ..
                //  we can design a prompt that runs for each of the courses 

                int numberOfCourses;
                Menu.promptUser("Select An Option :");
                Menu.promptUser("Enter Number Of Courses (enter a number): ");
                Menu.promptUser("Back To Main Menu (b)");
                var input = Console.ReadLine().ToLower();

                //checks if the user wants to go back to main menu
                if(input == "b")
                {
                    menu.setCurrentStage(1);
                }

                //parses the number of courses the user wanted to compute CGPA for
                else if (int.TryParse(input, out numberOfCourses))
                {
                    //this loops through the number of courses entered by the user and entering each course code and score  
                    for(int i = 1; i<= numberOfCourses; i++)
                    {
                        //user enters course code and this is attached to the iterator
                        Menu.promptUser($"Enter A Course Code For Course {i} : ");
                        string courseCode = Console.ReadLine();

                        Menu.promptUser($"Enter a Score for {courseCode} : ");
                        double score = Convert.ToDouble(Console.ReadLine());
                        
                        Menu.promptUser($"Enter a number Of Units for {courseCode} : ");
                        int units = Convert.ToInt32(Console.ReadLine());

                        //creates a new insance of Course class, converts courseCode, score and units to Course-Type 
                        repo.addCourse(new Course(courseCode, score, units)); //passes these Course-type parameters into addCorse method in the Repositiory Class
                    }

                        //<summary> 
                            //This prints out the list of courses entered by user
                        //</summary>

                        // var listofCourses = repo.getAllCourses();
                        // foreach(var course in listofCourses)
                        // {
                        //     System.Console.WriteLine(course.CourseCode + "        " + course.CourseScore  + "        " + course.NumberOfUnits);
                        // }

                   // menu.setCurrentStage(1);
                   menu.setCurrentStage(3);

                }
                else
                {
                    System.Console.WriteLine("Enter a valid number of courses...");
                    menu.setCurrentStage(2);
                }

                //menu.setCurrentStage(3);
                Console.Clear();

            }
        

            while(menu.getCurrentStage() == 3)
            {
                //we want to calculate grade points for all the courses that have been added
                System.Console.WriteLine("Welcome to CGPA Calculation mode");

                //returns list of courses in DB/Collection
                var listOfCourses = repo.getAllCourses();
                
                //calls the calculateCGPA method in Calulator class
                var calculatedResult = calc.calculateCGPA(listOfCourses);

                //loops through the list of courses
                foreach(var course in listOfCourses)
                {
                    System.Console.WriteLine(course.CourseCode + "        " + course.CourseScore  + "        " + course.NumberOfUnits);
                }
                System.Console.WriteLine($"Your CGPA is {calculatedResult} on a Scale of 5.0");
                break;
            }
            menu.setCurrentStage(1);
        }
        
    }
}
