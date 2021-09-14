using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma hinne.");
            int grade;
            grade = Convert.ToInt32(Console.ReadLine());


            if (grade == 5)

            {
                Console.WriteLine("Suurepärane");
            }
            else if (grade == 4)
            {
                Console.WriteLine("Väga hea");
            }
            else if (grade == 3)
            {
                Console.WriteLine("Hea");
            }


            else if (grade == 2)

            {
                Console.WriteLine("Rahuldav");
            }
            else if (grade == 1)
            {
                Console.WriteLine("Puudulik");
            }
            else
                Console.WriteLine("Puudulik");
        }
    }
}
