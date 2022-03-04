using System;

namespace Uc_7_RefactorCodeAndComputeEmpWage
{
    /// <summary>
    /// This code contain welcome massage for Emplyee Wage problem
    /// </summary>
    class Program
    {
       //constants
       public const int IS_PART_TIME=1;
       public const int IS_FULL_TIME=2;
       public const int EMP_WAGE_PER_HR = 20;
       public const int WORKING_DAYS = 20;
       public const int MAX_HR_IN_MONTH = 100;

        //variables
        public static int totalEmpHr = 0;
        public static int totalWorkingDays = 0;
        public static int empHr=0;
        public static int monthlySalary=0;
        /// this method is created for getting employee working hour
        ///<return>empHr<return>
        
        public static int GetWorkingHr(int rand)
        {
            
            switch(rand)
            {
                case IS_PART_TIME:
                    empHr=4;
                    break;

                case IS_FULL_TIME:
                    empHr = 8;
                    break;
                default:
                    empHr=0;
                    break;

            }
            return empHr;
        }

        ///This method is created for calculate employee wage
        
        public static void ComputeEmployeewage()
        {
            while(totalWorkingDays < WORKING_DAYS && totalEmpHr < MAX_HR_IN_MONTH)
            {
                totalWorkingDays++;
                Random random = new Random();
                int rand=random.Next(0,2);
                empHr=GetWorkingHr(rand);
                totalEmpHr=totalEmpHr+empHr;
            }
            monthlySalary = totalEmpHr * EMP_WAGE_PER_HR;
            Console.WriteLine("Total salary of Employee in month is " + monthlySalary);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage problem");
            Program.ComputeEmployeewage();
        }





        
                
       
    }
}
