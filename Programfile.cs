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


            //typecsting methods

           Console.WriteLine("Enter age :");//initially the program take value in String 

            int age= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Age="+age);
            

        }
    }
}
