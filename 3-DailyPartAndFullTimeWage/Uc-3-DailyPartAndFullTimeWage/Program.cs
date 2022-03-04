using System;

namespace Uc_3_DailyPartAndFullTimeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable initialization
            int SalaryPerHr = 20;
            int empHr;
            int TotalWage;
            int FullTime = 2;
            int PartTime = 1;
            Random random = new Random();
            int check = random.Next(0, 3);

            //conditional statment
            if (check == FullTime)
            {
                empHr = 8;
            }
            else if(check == PartTime)
            {
                empHr = 4;

            }
            else
            {
                empHr= 0;
            }
            //wages of employee
            TotalWage = SalaryPerHr * empHr;
            Console.WriteLine("DailyEmpWages Wages of Employee: " + TotalWage);

        }
    }
}
