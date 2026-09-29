using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    class Constr
    {
        public Constr()
        {
            Console.WriteLine("Constr 0");
        }

        public Constr(int x)
        {
            Console.WriteLine("Constr 1");
        }
        public Constr(string x)
        {
            Console.WriteLine("Constr 2");
        }
        public void M1()
        {
            Console.WriteLine("Task1");
        }

        public void M1(int x)
        {
            Console.WriteLine(" Task 2");
        }

        public void M1(string x)
        {
            Console.WriteLine(" Task 3");
        }
        public void M1(int x, int y)
        {
            Console.WriteLine(" Task 4");
        }

        public void M1(int x, string y)
        {
            Console.WriteLine(" Task 5");
        }
    }
}
