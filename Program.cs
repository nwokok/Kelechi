using System;

namespace Introductory_Tasks
{
    class SqrtProgram
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Speed - TimesTables - Circles");
                string choice = Console.ReadLine();
                if (choice == "Speed")
                {
                    Console.WriteLine("Min - ");
                    int mins = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Secs - ");
                    int secs = Int32.Parse(Console.ReadLine());
                    int time = mins * 60 + secs;
                    int speed1 = 10000 / time;
                    Console.WriteLine(Convert.ToString(speed1) + "m/s");
                    double hours = secs / 3600;
                    double speed2 = 0.6 / hours;
                    int speed3 = (int)speed2;
                    Console.WriteLine(Convert.ToString(speed3) + "mph");
                }
                if (choice == "TimesTables")
                {
                    Console.WriteLine("Pick a number from 1-12");
                    int num1 = Int32.Parse(Console.ReadLine());
                    int[] numList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                    foreach (int i in numList)
                    {
       
                        Console.WriteLine(num1 * i);
                    }
                }
                if (choice == "Circles")
                {
                    double pi = 3.14159;
                    Console.WriteLine("Pick - radius - area - circumference");
                    string circlechoice = Console.ReadLine();
                    if (circlechoice == "radius")
                    {
                        Console.WriteLine("Type in your radius");
                        int radius1 = Int32.Parse(Console.ReadLine());
                        double circ1 = 2 * radius1 * pi;
                        double area1 = pi * radius1 * radius1;
                        Console.WriteLine("You're circumference is - " + circ1.ToString("F"));
                        Console.WriteLine("You're area is - " + area1.ToString("F"));
                    }
                    if (circlechoice == "area")
                    {
                        Console.WriteLine("Type in your area");
                        int area2 = Int32.Parse(Console.ReadLine());
                        double radius2 = Math.Sqrt(area2 / pi);
                        double circ2 = 2 * radius2 * pi;
                        Console.WriteLine("You're radius is - " + radius2.ToString("F"));
                        Console.WriteLine("You're circumference is - " + circ2.ToString("F"));

                    }
                    if (circlechoice == "circumference")
                    {
                        Console.WriteLine("Type in your circumference");
                        int circ3 = Int32.Parse(Console.ReadLine());
                        double radius3 = circ3 / (2 * pi);
                        double area3 = pi * radius3 * radius3;
                        Console.WriteLine("You're radius is - " + radius3.ToString("F"));
                        Console.WriteLine("You're area is - " + area3.ToString("F"));
                    }
                }
                Console.WriteLine("Do you want to try again - y or n");
                string again = Console.ReadLine();
                if (again == "n")
                {
                    break
                }
            }
            
        }
    }
}
