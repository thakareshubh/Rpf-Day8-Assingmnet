using System;

namespace Uc_4_UseOfSwitchInDailyWagePartTimeFullTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable initialization
            int SalaryPerHr = 20;
            int empHr;
            int TotalWage;  
            Random random = new Random();
            int check = random.Next(0, 3);

            //Switch statment
            switch (check) 
            {
                case 1:empHr = 8;
                    break;

                case 2:empHr = 4;
                    break;

                default:
                    empHr = 0;
                    break;
                    
             }
            
            //wages of employee
            TotalWage = SalaryPerHr * empHr;
            Console.WriteLine("DailyEmpWages Wages of Employee: " + TotalWage);

        }
    }
}
