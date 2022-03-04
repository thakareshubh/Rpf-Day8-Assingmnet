using System;

namespace Uc_1_presentAbsent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable initialization
            int isPresent = 1;
            Random random = new Random();
            int check = random.Next(0, 1);

            //conditional statment 
            if (check == isPresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is not present");
            }
        }
    }
}
