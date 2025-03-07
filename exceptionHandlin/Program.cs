using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandlin
{
    internal class Program
    {
        static double SafeDivision(double x, double y) { 
            if (y==0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }

        static void Activity1 ()
        {
            double a = 98, b = 0;
            double result;
            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void Activity2()
        {
            var tempRecord = new TempRecord();
            tempRecord[3] = 58.2F;
            tempRecord[5] = 59.2F;

            tempRecord.DisplayTempRecord();

            try
            {
                tempRecord[10] = 50.5F;
                Console.WriteLine($"tempRecord[10] => {tempRecord[10]}"); // out of range
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void Activity3 ()
        {
            DaysOfWeek days = new DaysOfWeek();
            Console.WriteLine($"day at 2: {days[2]}");
            Console.WriteLine($"index of Friday: {days["Friday"]}");

            try
            {
                Console.WriteLine($"days[7]: {days[7]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                Console.WriteLine($"days['weekday']: {days["weekday"]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void Activity4 ()
        {
            var stringCollection = new GenericStorage<string>();
            stringCollection[0] = "Hello world";
            Console.WriteLine(stringCollection[0]);
        }

        static string ReadString(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input)) return input;
                
                Console.Write("Try again<string>: ");
            }
        }

        static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int value)) return value;
                Console.Write("Try again<int>: ");
            }
        }

        static float ReadFloat(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (float.TryParse(Console.ReadLine(), out float value)) return value;
                Console.Write("Try again<float>");
            }
        }

        static void Task1()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter details of Student:{i + 1}:");
                string name = ReadString("Name: ");
                int age = ReadInt("Age: ");
                float gpa = ReadFloat("GPA: ");
                students.Add(new Student { Name = name, Age = age, GPA = gpa });
            }

            Console.WriteLine("\n\nPrinting Student information:");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, GPA: {student.GPA}");
            }
        }


        static void Main(string[] args)
        {
            //Activity1 ();
            //Activity2();
            //Activity3();
            //Activity4();
            Task1();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
