using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
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
        }

        void question1()
        {
            string name;
            Console.Write("Enter your name :");
            name = Console.ReadLine();

            Console.Write("Enter your batch number :");
            double batch = double.Parse(Console.ReadLine());

            Console.Write(name + " your batch is " + batch);

            Console.ReadKey();

        }

        void question2()
        {
            Console.WriteLine("Enter  the radius : ");
            int r = int.Parse(Console.ReadLine());

            int A = (22 * r * r) / 7;
            Console.WriteLine("Area is " + A);

            Console.ReadKey();

        }

        void question3()
        {
            Console.WriteLine("Enter first number : ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int y = int.Parse(Console.ReadLine());

            int sum =x + y;
            Console.WriteLine("Summation is " + sum);

            Console.ReadKey();

        }

        void question4()
        {
            Console.WriteLine("Enter your salary in Rupees : ");
            double sal = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter yoour TAX rate : ");
            double tax = double.Parse(Console.ReadLine());

            double tot = (sal * (100 - tax)) / 100;
            Console.WriteLine("Your salary after TAX is Rs." + tot);

            Console.ReadKey();

        }
    }
}