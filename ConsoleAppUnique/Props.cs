using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    public class Props
    {
        public int x, y, z;
        // default scope of x,y,z
    }

    public class Props2 : Props
    {
        public void Add()
        {
            x = 24;
            y = 34;
            z = x + y;
        }
    }


    public class RefOut
    {
        public void Cal(ref int x)  // x=9090 , 121212 =10
        {
            Console.WriteLine("before x:" + x); // 10
            x = x + 10; // x=20
            Console.WriteLine("before x:" + x); // x= 20
        }


        // * &
        public void Exe()
        {
            int y = 10;
            Console.WriteLine("print y , before calling cal fun:" + y); // 10
            Cal(ref y);  // y=10 , call by value , fun call by
            Console.WriteLine("print y , after calling cal fun:" + y); // y = 20

            // y=121212 = 10
            // x=0909090 

            // y => x --> x will be  , x will override
        }

        public void Ops()
        {
            Console.WriteLine(" method with no return value");
        }

        public int Ops1()
        {
            return 1;
        }

        public string Ops2()
        {
            return "hi";
        }

        public (int, string) Ops3()
        {
            return (12, "test");
        }

        public void Ops4(int x, int y , out int add, out int sub , out int mul)
        {
            add = x + y;
            sub = x - y;
            mul = x * y;
        }
    }
}
