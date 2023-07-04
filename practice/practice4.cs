using System;

namespace Practice4
{
    class program
    {
        static void Main(string[] args)
        {
            int n1,n2,tmp;

            Console.Write("Enter first number : ");

            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number : ");

            n2 = Convert.ToInt32(Console.ReadLine());

            tmp = n1;
            n1 = n2;
            n2 = tmp;

            Console.WriteLine("Swaped number first : "+n1);
            Console.WriteLine("Swaped number second : "+n2);
        }
    }
}
