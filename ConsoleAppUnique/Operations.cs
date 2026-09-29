using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{

    // int string
    // var dynamic & object --> How 
    internal class Operations
    {
        public void Add()
        {
            int x = 3, y = 365, z;
            z = x + y;
            Console.WriteLine("Add is:" + z);
        }
        public void Sub(int x, int y = 1)
        {
            int z;
            z = x - y;
            Console.WriteLine("Sub is:" + z);
        }
        public int Mul(int x, int y)
        {
            int z;
            z = x * y;
            Console.WriteLine("Mul is:" + z);
            return z;
        }

        // void dosnt return anything
        // int float , strng , char 

        // from human body

        // part is taking input and returning o/p
        // hand is taking catch --> returning ball
        // nose o2 and co2
        // skin feel 
        // input --> no output --> void 

        // ear --> sound --> brain and ur body react

        // options and default value
        public void Opspm(int x , params int[] y) {
            Console.WriteLine("x:"+x);
            foreach (var item in y)
            {
                Console.WriteLine("Y:"+item);
            }
        }

        public static void M1() { // static fun
            Console.WriteLine("M1 fun");
        }
    }
}
