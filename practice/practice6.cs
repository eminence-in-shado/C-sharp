using System;

namespace Practice6
{
    class program 
    {
        static void Main(string[] args)
        {
          // declare variables
            int n1,n2,add,sub,mul,div,mod;

          // taking input from user
            Console.Write("Enter a number: ");

            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");

            n2 = Convert.ToInt32(Console.ReadLine());

          // Logic 
            add = n1+n2;
            sub = n1-n2;
            mul = n1*n2;
            div = n1/n2;
            mod = n1%n2;

          // Printing output
            Console.WriteLine(n1 + "+" + n2 + "=" + add);
            Console.WriteLine(n1 + "-" + n2 + "=" + sub);
            Console.WriteLine(n1 + "*" + n2 + "=" + mul);
            Console.WriteLine(n1 + "/" + n2 + "=" + div);
            Console.WriteLine(n1 + "%" + n2 + "=" + mod);
        }
    }
}
