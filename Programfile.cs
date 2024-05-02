using System;
using System.Collections.Generic;
using System.Text;

namespace program.Introduction_To_C_Sharp
{
    internal class Programfile

    {
        static void Main()
        {
      

         //operators in c#

            //arithmatic operators 

            int a=(int)10;
            int b =(int) 15;
            Console.WriteLine(a + b);
            Console.WriteLine(b - a);


            Console.WriteLine(a * b);

            Console.WriteLine(a / b);
            Console.WriteLine( a % b);

            Console.WriteLine(a++);
            Console.WriteLine(b++);
            Console.WriteLine(a--);


            //Logical

            int val1 = 5;
            int val2 = 15;
            if (val1 < 10 || val2 < 10)
            {
                Console.WriteLine(val1);
            }
            else
            {
                Console.WriteLine(val2);
            }


            //Assignment

            int val3 = 50;
            Console.WriteLine(val3+=5);

            //Comparision

            int val4 = 20;
            int val5 = 30;

            if (val4 == val5)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }




        }
    }
}
