using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program x = new Program();
            x.question1();
            x.question2();
            x.question3();
            x.question4();
            x.question5();
        }

        void question1()
        {
            Console.WriteLine("Enter first number : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine("Summation is " + sum);

            Console.ReadKey();

        }

        void question2()
        {
            Console.WriteLine("Enter first number : ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            double y = double.Parse(Console.ReadLine());

            double sum = x + y;
            Console.WriteLine("Summation is : " + sum);

            double sub = x - y;
            Console.WriteLine("Substraction is : " + sub);

            double mul = x * y;
            Console.WriteLine("Multiplication is : " + mul);

            double div = x / y;
            Console.WriteLine("Division is : " + div);

            Console.ReadKey();

        }

        void question3()
        {
            Console.WriteLine("Enter the radius : ");
            double r = double.Parse(Console.ReadLine());

            double C = (2 * 22 * r) / 7;
            double A = (22 * r * r) / 7;

            Console.WriteLine("Circumferance is " + C);
            Console.WriteLine("Area is " + A);

            Console.ReadKey();

        }

        void question4()
        {
            Console.WriteLine("Enter a number : ");
            double a = double.Parse(Console.ReadLine());

            double no = a % 2;
            if (no == 0)
            {
                Console.WriteLine(a + " is a an even number");
            }
            else
            {
                Console.WriteLine(a + " is an odd number");
            }

            Console.ReadKey();

        }

        void question5()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number : ");
                double a = double.Parse(Console.ReadLine());

                double no = a % 2;
                if (no == 0)
                {
                    Console.WriteLine(a + " is a an even number");
                }
                else
                {
                    Console.WriteLine(a + " is an odd number");
                }
            }

            Console.ReadKey();

        }
    }
}