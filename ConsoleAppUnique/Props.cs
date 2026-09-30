using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    public class Props
    {
        public int res { get; set; } = 0;


        private int x;
        public int x_
        {
            get { return x; }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("Values are not in the range");
                }
                else
                {
                    x = value;
                }
            }
        }

        private int y;

        public int y_
        {
            get { return y; }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("Values are not in the range");
                }
                else
                {
                    y = value;
                }
            }
        }


        public int Add()
        {
            int z = x + y;
            return z;
        }

        // info , address
        // default scope of x,y,z

        // we make use properties
        // spl fun , getter and setter , private are exposed publicliy thrw prop
        // x_ is like a alis for private field


        public void ISAS()
        {
            string str = null;

            // is returns a bool values
            // as will compare and returns a value
            object[] arr = { 12, "hi", 43.45, true, "Hello" };

            for (int i = 0; i < arr.Length; i++)
            {
                string res = arr[i] as string;
                // 12 is not a string TF , Null
                // Hi is string , TF , HI
                if (res is null)
                {
                    Console.WriteLine("No value");
                }
                else
                {
                    Console.WriteLine(res);
                }

            }



            if (str is null) // TF
            {
                Console.WriteLine(" Str is   null");
            }
            else
            {
                Console.WriteLine(" str has a value");
            }
        }
    }

    public class Props2 : Props
    {
        public void Add()
        {

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

        public void Ops4(int x, int y, out int add, out int sub, out int mul)
        {
            add = x + y;
            sub = x - y;
            mul = x * y;
        }
    }
}
