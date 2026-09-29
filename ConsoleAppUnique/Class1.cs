using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    static class Class1
    {
        public static void ProExpDate(this Products obj)
        {
            Console.WriteLine("Pro exp data");
        }

        public static void ProProfit(this Products obj)
        {
            Console.WriteLine("Profit data");
        }
    }

    public class Test
    {

        public int x, y;
        public Test(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


    }
}
