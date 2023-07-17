using System;
namespace Assignment08
//ASSIGNMENT 08
//METHODS AND PARAMETERS IN C#
{
        public class Calc
        {
            public static int CalcSalary(int eType, int eWHours, int eWDays, int ProjectHandles, int Extras)
            {
                int salary = 0;

                switch (eType)
                {
                    case 1:
                        salary = eWHours * eWDays * 100;
                        break;
                    case 2:
                        salary = (eWHours * eWDays * 100) + (ProjectHandles * 3000);
                        break;
                    case 3:
                        salary = (eWHours * eWDays * 100) + (   ProjectHandles * 3000) + (Extras * 2000);
                        break;
                    default:
                        Console.WriteLine("Invalid employee Type!!!");
                        break;
                }
                return salary;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Choose Employee type:");
                Console.WriteLine("1.HR");
                Console.WriteLine("2.Admin");
                Console.WriteLine("3.Software Developer");
                int eType = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter working hours");
                int eHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter no of working days");
                int eWDays = Convert.ToInt32(Console.ReadLine());

                int ProjectHandels = 0;
                int Extras = 0;
                if (eType == 2 || eType == 3)
                {
                    Console.WriteLine("enter project handels");
                    ProjectHandels = Convert.ToInt32(Console.ReadLine());

                }
                if (eType == 3)
                {
                    Console.WriteLine("enter extras");
                    Extras = Convert.ToInt32(Console.ReadLine());
                }

                int salary = Calc.CalcSalary(eType, eHours, eWDays, ProjectHandels, Extras);
                Console.WriteLine("mothly salary:" + salary);
                Console.ReadKey();
            }
        }
    }