using System;
using System.Collections.Generic;
using System.Text;

namespace program.Introduction_To_C_Sharp
{
    internal class Programfile

    {
        static void Main()
        {

      

          
            int a = 10;
            float b = a;
                                        //implicit - int to float
            Console.WriteLine(a);//10
            Console.WriteLine(b);//10


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




            int val1 = 10;
            long val2 = 10010;
            float val3 = 1.05f;
            double val4 = 9.999f;
            bool val5 = true;
            char val6 = 'A';
            string val7 = "My name is Tanushree";

            Console.WriteLine("val1=" + val1);
            Console.WriteLine("val2=" + val2);
            Console.WriteLine("val3=" + val3);
            Console.WriteLine("val4=" + val4);
            Console.WriteLine("val5=" + val5);
            Console.WriteLine("val6=" + val6);
            Console.WriteLine("val7=" + val7);
          

        }
    }
}
