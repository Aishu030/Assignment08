using System;
namespace Assignment08
//ASSIGNMENT 08
//METHODS AND PARAMETERS IN C#
{
    class Salary
    {
        public double CalSalary(double wHour, double nWDays, double projectHandles = 1, double extras = 0)
        {
            double salary = wHour * nWDays * 100 + projectHandles * 3000 + extras * 2000;
            return salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Salary obj = new Salary();

            //*********************Salary Calculation System*****************
            Console.WriteLine("Choose the type of employee :");
            Console.WriteLine("type 1 below for HR");
            Console.WriteLine("type 2 below for Admin");
            Console.WriteLine("type 3 below for Software Developer");

            int employeeType = int.Parse(Console.ReadLine());

            double wHour = 9;
            double nWDays = 30;
            double projectHandles = 0;
            double extras = 0;

            switch (employeeType)
            {
                case 1: //type 1 HR
                       break;
                case 2: //type 2 for admin
                    Console.WriteLine("Enter the number of project handles:");
                    projectHandles = double.Parse(Console.ReadLine());
                    break;
                case 3: //type 3 for software developer
                    Console.WriteLine("Enter the number of project handles:");
                    projectHandles = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the value of extras:");
                    extras = double.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid employee type selected.");
                    break;
            }

            double calculatedSalary = obj.CalSalary(wHour, nWDays, projectHandles, extras);
            Console.WriteLine($"Monthly Salary: {calculatedSalary}");
            Console.ReadKey();
        }
    }
}