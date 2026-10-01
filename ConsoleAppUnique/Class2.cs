using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    public class Class2
    {
        public static void M1()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {

                    string str = null;
                    Console.WriteLine(str.Length);
                }
               
                Console.WriteLine("M1 method");
            }
        }

        public static void M2(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("M2 method");
            }
        }
    }
}


// 100000+ lines --> runtime 