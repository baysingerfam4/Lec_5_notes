using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.ComponentModel.Design;
using System;

namespace Lec_5_notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Carla Baysinger
            // Lecture 5 Notes
            // April 24th 2024
            Part1();


        }//Main

        public static void Part1()
        {

            //Write code that asks the user for their altitude (the height the plane is flying at ) as if they were flying an airplane. 
            //Save the answer as a double.
            //Convert that number to meters.
            //Formula : Meters = Feet × 0.3048
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
            double lowaltitude = double.Parse(Console.ReadLine());
            bool isGreaterOrEqualTo305 = lowaltitude >= 305;
            bool isLessThanOrEqualTo1524 = lowaltitude <= 1524;
            bool bw305And1524 = isGreaterOrEqualTo305 || isLessThanOrEqualTo1524;
            double num = 0.3048;
            double meters = lowaltitude * num;

            double medaltitude = double.Parse(Console.ReadLine());
            bool isGreaterOrEqualTo1525 = medaltitude >= 1525;
            bool isLessThanOrEqualTo7620 = medaltitude <= 7620;
           bool bw1525And7620 = isGreaterOrEqualTo1525 ||isLessThanOrEqualTo7620;
            double meters2 = medaltitude * num;


            if (lowaltitude >= 305 || lowaltitude <= 1524)
            {
                Console.WriteLine($"Your current altitude is {lowaltitude} ({meters} meters)");
                Console.WriteLine("Low Altitude");
                Console.WriteLine("This altitude is used for takeoff and landing");

            }

            else if(medaltitude > 1525 || medaltitude < 7620) 
            {
                Console.WriteLine($"Your current altitude is {medaltitude} ({meters2} meters) Medium Altitude This is considered a Good Altitude for a plane to fly at.");
            
            }


            
           

        }

        public static void Part2()
        {
           // Grade Calculator

           //Write a C# program that takes a numerical grade as input from the user and outputs the corresponding letter grade based on the following grading scale:

           //If the grade is greater than or equal to 90, output "A"
           //If the grade is greater than or equal to 80 and less than 90, output "B"
           //If the grade is greater than or equal to 70 and less than 80, output "C"
           //If the grade is greater than or equal to 60 and less than 70, output "D"
           //If the grade is less than 60, output "F"
           //Additionally, if the grade is greater than 100 output an error message indicating that the grade is invalid.

        }

        public static void Part()
        {

            //Create a menu that prompts the user to choose from either

            //1.Altitude checker

            //2.Grade Calculator

            //3.Exit

            //Use if / else if / else to create the menu structure.
        }

        public static void Questions()
        {
            //In programming, conditions like if / else if/ and else blocks are known as a D_______ S________.

            //If you have an if / else if / else structure, how many code blocks can run in a single structure ?
            //if (condition)  { //if statement }
            //else if (another condition ) { // else if statement }
            //else { else statement }

            //Which code block will run?

            //If you have two if separate statements, can these both run?
            //if (condition) { // first if }            
            //if (second condition { // second if }

            //How many if else if statements can you have?

            //Can you have an else if / else without an if?
            //else if (condition) { // else if statement }            
            //else { // else statement }
            //
            // Can you have an if without an else?
           // if (condition)
                                           // { // if statement }
            // Which logical operator do you choose if you have 2 Conditions and both need to be true ?
            //Which logical operator do you choose if you have 2 Conditions, but only one needs to be true ?


        }


    }//class
}//namespace
