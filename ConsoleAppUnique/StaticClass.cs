using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    static class StaticClass
    {

        static StaticClass()
        {
            Console.WriteLine(" static const");
        }


        public static void m1(int x)
        {
            Console.WriteLine(" m1 ");
        }
        public static void m2() { }  // error , non static , object 
    }
}
