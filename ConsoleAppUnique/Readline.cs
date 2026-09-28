using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    internal class Readline
    {
        public void test()
        {
            /* Console.WriteLine("Enter ur name:");
             string uname = Console.ReadLine();  // input from keyboard at run time
             Console.WriteLine("ur name is :" + uname);


             Console.WriteLine("Enter ur age:");
             byte age = Convert.ToByte(Console.ReadLine()); // --> string only 
             // convetion and parsing
             Console.WriteLine("ur age is :" + age);


             Console.WriteLine("Enter ur grade:");
             byte grade = byte.Parse(Console.ReadLine()); // --> string only 
             // convetion and parsing
             Console.WriteLine("ur grade is :" + grade);


             int i = Convert.ToInt32(Console.ReadLine());
             byte b = Convert.ToByte(Console.ReadLine());
             sbyte sb = Convert.ToSByte(Console.ReadLine());
             double d = Convert.ToDouble(Console.ReadLine());
            */

            // works
            // Console.WriteLine("enter hetre ..");
            // int x = Convert.ToByte((Console.ReadLine()));  // run time 
            // int 4 bytes --> byte 1 byte


            string str = null;
            //  int res1 = Convert.ToInt32(str);     // accepts null
            int res2 = int.Parse(str); // no null allowed , sol for this to handle error
                                       // HW 
            Console.WriteLine(res2);


            // nullable 

            // ref type
            // len is not fixed
            // arrays , object ,
            string s = null;
            int[] arr = null;


            // value
            // len is fixed
            // int float  double 
            int? s1 = null;  // s1 as nullable
            Nullable<float> f = null;


            // implict & explict 
            // lower is heigher --> implict
            // vice versa

            byte b1 = 78;
            int i1 = b1;  // implict 
            byte b2 = (byte)i1;  // explict , loss of data
            Console.WriteLine(i1);

            // boxing & unboxing
            // value to ref
            // ref to value

            int x2 = 234;
            object o2 = x2; // boxing
            int x3 = (int)o2;  // unboxing , expl

            int[] arr1 = { 234, 345, 45645, 646, 567, 678 };
            Console.WriteLine(arr1[0]);
        }
    }
}
