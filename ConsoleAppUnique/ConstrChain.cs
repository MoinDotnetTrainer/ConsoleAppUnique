using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{

    public partial class Emp
    {
        public void EmpProjectDetails()
        {
            Console.WriteLine("Emp details");
        }
    }
    public class ConstrChain
    {
        public ConstrChain() : this(12)
        {
            Console.WriteLine("def const");
        }

        public ConstrChain(int x) : this("test")
        {
            Console.WriteLine("1 int");
        }

        public ConstrChain(string x)
        {
            Console.WriteLine("1 string");
        }

        public ConstrChain(int x, int y)
        {
            Console.WriteLine("2 int");
        }
    }

    public class Child : ConstrChain
    {

        public Child() : base()
        {
            Console.WriteLine(" child constr");
        }

    }
}
