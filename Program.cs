using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.ComponentModel.Design;
using System;
using System.Text;

namespace Lec_5_notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Carla Baysinger
            // Lecture 5 Notes
            // April 24th 2024
            AltitudeChecker();
            GradeCalculator();
            Menu();


        }//Main

        public static void AltitudeChecker()
        {

             
             //Use the chart below to display the appropriate message depending on the user's input:

            //305 - 1524
            //Low Altitude
            //This altitude is used for takeoff and landing

            //1524 - 7620
            //Medium Altitude
            //This is considered a Good Altitude for a plane to fly at.

            //7621 and Above
            //High Altitude
            //This altitude is for long-range, high-speed flights

            Console.Write("What is your current altitude in feet: ");
            //Write code that asks the user for their altitude (the height the plane is flying at ) as if they were flying an airplane.
            double Altitude = double.Parse(Console.ReadLine());
            //Save the answer as a double.
            
            bool isGreaterOrEqualTo305 = Altitude >= 305; //saved greater and less than as bool
            bool isLessThanOrEqualTo1524 = Altitude <= 1524;
            bool bw305And1524 = isGreaterOrEqualTo305 && isLessThanOrEqualTo1524;
            bool isGreaterOrEqualTo1525 = Altitude >= 1525;
            bool isLessThanOrEqualTo7620 = Altitude <= 7620;
            bool bw1525And7620 = isGreaterOrEqualTo1525 && isLessThanOrEqualTo7620;
            bool isGreaterOrEqualTo7621 = Altitude >= 7621;
            

            double num = 0.3048;
            double meters = Altitude * num;
            //Convert that number to meters.
            //Formula : Meters = Feet × 0.3048

            // Displayed depending on users input

            if (bw305And1524)
            {

                Console.WriteLine($"Your current altitude is {Altitude} feet ({meters} meters)");
                Console.WriteLine("Low Altitude");
                Console.WriteLine("This altitude is used for takeoff and landing");

            }

            else if (bw1525And7620)
            {

                Console.WriteLine($"Your current altitude is {Altitude} feet ({meters} meters)");
                Console.WriteLine("Medium Altitude");
                Console.WriteLine("This is considered a Good Altitude for a plane to fly at.");

            }

           else if (isGreaterOrEqualTo7621)
            {
                Console.WriteLine("High Altitude");
                Console.WriteLine("This altitude is for long - range, high - speed flights");

            }

            else
            {
                Console.WriteLine("invalid");
                Console.ReadKey();
            }
                  
           

        }

        public static void GradeCalculator()
        {
            // Grade Calculator

            //Write a C# program that takes a numerical grade as input from the user and outputs the corresponding letter grade based on the following grading scale:

            //If the grade is greater than or equal to 90, output "A"
            //If the grade is greater than or equal to 80 and less than 90, output "B"
            //If the grade is greater than or equal to 70 and less than 80, output "C"
            //If the grade is greater than or equal to 60 and less than 70, output "D"
            //If the grade is less than 60, output "F"
            //Additionally, if the grade is greater than 100 output an error message indicating that the grade is invalid.

            Console.WriteLine("Enter your numerical grade? ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("Your grade is: A");
            }
            else if(grade >= 80 && grade < 90)
            {
                Console.WriteLine("Your grade is: B");
            }
            else if(grade >= 70 && grade < 80){
                Console.WriteLine("Your grade is: C");
            }
            else if(grade >= 60 && grade < 70)
            {
                Console.WriteLine("Your grade is:D");
            }
            else if(grade < 60)
            {
                Console.WriteLine("Your grade is: F");
            }
            else
            {
                Console.WriteLine("grade invalid"); // Error message for grade over 100
                Console.ReadKey();
            }

        }

        public static void Menu()
        {

            //Create a menu that prompts the user to choose from either

            //1.Altitude checker

            //2.Grade Calculator

            //3.Exit

            //Use if / else if / else to create the menu structure.
            Console.WriteLine("What example do you want to run?");
            Console.WriteLine("1 - Altitude Checker");
            Console.WriteLine("2 - Grade Calculator");
            Console.WriteLine("3 - Exit");
            Console.WriteLine("Enter your choice (1 - 3): ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                AltitudeChecker();

            }
            else if (userInput == "2")
            {
                GradeCalculator();
            }
            else
            {
                Console.WriteLine("Have an awesome day! ");
                Console.ReadKey();
                    
            }
                
        }

        public static void Questions()
        {
            //In programming, conditions like if / else if/ and else blocks are known as a D_______ S________.
            //Conditional Statements is the only thing I can find

            //If you have an if / else if / else structure, how many code blocks can run in a single structure ?
            //You can have as many as needed but it maybe difficult to work with if you have too many.
            //if (condition)  { //if statement }
            //else if (another condition ) { // else if statement }
            //else { else statement }

            //Which code block will run? Any can run depending on the answer.

            //If you have two if separate statements, can these both run? Yes both can run
            //if (condition) { // first if }            
            //if (second condition { // second if }

            //How many if else if statements can you have? As many as needed

            //Can you have an else if / else without an if? No
            //else if (condition) { // else if statement }            
            //else { // else statement }
            //
            // Can you have an if without an else? Yes at least it ran when I tried
           // if (condition)
                                           // { // if statement }
            // Which logical operator do you choose if you have 2 Conditions and both need to be true ? &&
            //Which logical operator do you choose if you have 2 Conditions, but only one needs to be true ? ||


        }


    }//class
}//namespace
