using System;

namespace Uc_2_DailyEmpWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable initialization
            int SalaryPerHr = 20;
            int empHr;
            int TotalWage;
            int FullTime = 1;
            Random random = new Random();
            int check = random.Next(0, 1);

            //conditional statment
            if (check == FullTime)
            {
                empHr = 8;
            }
            else
            {
                empHr = 0;

            }
            //wages of employee
            TotalWage = SalaryPerHr * empHr;
            Console.WriteLine("DailyEmpWages Wages of Employee: " + TotalWage);

        }
    }
}
