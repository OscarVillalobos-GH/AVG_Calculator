using System;
using System.Numerics;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // start , Tittle of the mini program
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("--------------------Start-------------------");
                Console.WriteLine("-----------Grade Calculator Program---------");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter numeric values between 0 and 100");
                Console.WriteLine();

                // start with the question and enter the value

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter marks for Maths (0 to 100): ");
                int maths = int.Parse(Console.ReadLine());

                Console.Write("Enter marks for Physics (0 of 100): ");
                int physics = int.Parse(Console.ReadLine());

                Console.Write("Enter marks for Chemistry (0 of 100): ");
                int chemistry = int.Parse(Console.ReadLine());

                Console.Write("Enter marks for Computer Science (0 of 100): ");
                int computer = int.Parse(Console.ReadLine());

                // start to calculate the average marks
                double AVGMarks = AVG(maths, physics, chemistry, computer);

                // Check what is the grade
                char grade = whatsGrade(AVGMarks);

                // 
                DisplayRemarks(grade);
            }
            // Format Exeption

            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Only enter numeric values between 0 and 100.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        // calculation of the 4 subjects
        static double AVG(int maths, int physics, int chemistry, int computer)
        {
            // Divide by 4 
            double average = (maths + physics + chemistry + computer) / 4.0;
            return average;
        }

        // Function to determine the grade based on average marks

        static char whatsGrade(double AVGMarks)
        {
            if (AVGMarks >= 80) return 'A';
            else if (AVGMarks >= 70) return 'B';
            else if (AVGMarks >= 60) return 'C';
            else if (AVGMarks >= 50) return 'D';
            else return 'F';
        }

        // Show the cases  Switch--

        static void DisplayRemarks(char grade)
        {
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent! Your grade is A");
                    break;
                case 'B':
                    Console.WriteLine("Good! Your grade is B");
                    break;
                case 'C':
                    Console.WriteLine("Satisfactory. Your grade is C");
                    break;
                case 'D':
                    Console.WriteLine("Pass. Your grade is D");
                    break;
                case 'F':
                    Console.WriteLine("Fail. Your grade is F");
                    break;
                }
        }
    }
}
