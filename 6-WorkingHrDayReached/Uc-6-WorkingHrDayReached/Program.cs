using System;

namespace Uc_6_WorkingHrDayReached
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constant
            int FullTime = 1;
            int PartTime = 2;
            int SalaryPerHr = 20;
            int MaxDayOfWorking = 20;
            int TotalWorkingHr = 100;

            //variable
            int WorkingDay = 0;
            int WorkingHour = 0;
            int empHr=0;

            //computation
            void method1()
            {
                Random random = new Random();
                int check = random.Next(0, 3);
                if (check == FullTime)
                {
                    empHr = 8;
                }
                else if (check == PartTime)
                {
                    empHr = 4;
                }
                else
                {
                    empHr = 0;
                }
            }

            while(WorkingDay<=MaxDayOfWorking||WorkingHour<=TotalWorkingHr)
            {

                WorkingDay++;
                int  Hr=medhod1();

                WorkingHour = WorkingHour + Hr;
            }

            int TotalSalary=WorkingHour* SalaryPerHr;
            Console.WriteLine("Total salary of Employee: "+TotalSalary);
        }
    }
}
