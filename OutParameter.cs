using System;

namespace OutParameter
{
    class Program
    {
      //User defined function
        public void Show(out int val)//Out Parameter
        {
            int square=5;
            val=square;

            val *= val;//Manipulating
        }

        static void Main(string[] args)
        {
          int val=50;

          Program program = new Program(); // 
          Console.WriteLine("Value before Out "+val);
          program.Show(out val);//After Out
          Console.WriteLine("Value after Out "+val);
        }
    }
}
