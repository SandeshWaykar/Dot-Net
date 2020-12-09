using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQ1
{
    public delegate decimal SimpleInterest(decimal P, decimal N, decimal R);
    class Program
    {
        static void Main(string[] args)
        {
            SimpleInterest s1 = (P, N, R) =>
              {

                  return P * R * N / 100;
              };

            Console.WriteLine("Enter P :");
            decimal pri = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter N : ");
            decimal re = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter R : ");
            decimal ne = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Simple Interest is : " + s1(pri, re, ne));

            Console.ReadLine();
        }
    }
}

namespace AssignmentQ2
{
    class Program
    {
        public delegate bool isGreater(int a, int b);
        static void Main(string[] args)
        {

            isGreater g1 = (a, b) =>
             {

                 if(a>b)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }

             };

            Console.WriteLine(g1(20, 30));

            Console.ReadLine();

        }
    }
}


namespace AssignmentQ3
{

    public delegate decimal GetBasic(decimal basic);
    class Program
    {
        static void Main(string[] args)
        {
               GetBasic g1 = (basic) =>
            {
                return basic;
            };

            Console.WriteLine("Basic salary is : " + g1(12000));

            Console.ReadLine();

        }
    }

}

namespace AssignmentQ4
{

    public delegate bool IsEven(int number);
    class Program
    {
        static void Main(string[] args)
        {

            IsEven e1 = (number) =>
            {

                return number % 2 == 0;
            
            };

            Console.WriteLine("Enter number : ");

            int temp = int.Parse(Console.ReadLine());

            Console.WriteLine("IsEvent : " + e1(temp));

            Console.ReadLine();
        }
    }
}

namespace AssignmentQ5
{

    public delegate bool IsGreaterThan(decimal basic);
    class Program
    {

        static void Main(string[] args)
        {

            IsGreaterThan g1 = (basic) =>
            {
                if(basic>10000)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            };

            Console.WriteLine("Enter Basic : ");

            int temp = int.Parse(Console.ReadLine());

            Console.WriteLine("IsGreaterThan 10000 : " + g1(temp));

            Console.ReadLine();

        }
    }
}