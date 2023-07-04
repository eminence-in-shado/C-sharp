using System;

namespace Practice5
{
    class program 
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,res;
            
            System.Console.Write("Enter first num : ");

            n1 = Convert.ToInt32(Console.ReadLine());
            
            System.Console.Write("Enter second num : ");
            
            n2 = Convert.ToInt32(Console.ReadLine());
            
            System.Console.Write("Enter third num : ");
            
            n3 = Convert.ToInt32(Console.ReadLine());

            res = n1*n2*n3;

            Console.WriteLine(n1 + "x" + n2 + "x" + n3 + "=" + res);
            
            // you can also print result directly :
            // Console.WriteLine("multiplication of all 3 numbers : "+res);
        }
    }
}
