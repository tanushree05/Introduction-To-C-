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

            double c = 10.99;
                              //explicit -double to int 
            int d = (int)c;

            Console.WriteLine(c);
            Console.WriteLine(d);


           

           Console.WriteLine("Enter age :");//initially the program take value in String 

            int age= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Age="+age);
            

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
