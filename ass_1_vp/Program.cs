using System;

namespace ass_1_vp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            switch (age)
            {
                case int n when (n >=0 && n <= 12):
                    Console.WriteLine("You are child");
                    break;
                case int n when (n >= 13 && n <= 19):
                    Console.WriteLine("You are teenager");
                    break;
                case int n when (n >= 20 && n <= 64):
                    Console.WriteLine("You are adult");
                    break;
                case int n when (n >= 65):
                    Console.WriteLine("Senior");
                    break;
                default: 
                    Console.WriteLine("Invalid input");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
