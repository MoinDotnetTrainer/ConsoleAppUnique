using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique.Solid
{
    public interface Iworker
    {
        void Work();
        void Eat();
        void Sleep();
    }

    class Human : Iworker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working");
        }
        public void Eat()
        {
            Console.WriteLine();
        }
        public void Sleep()
        {
            Console.WriteLine();
        }
    }


    class Robot : Iworker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working");
        }
        public void Eat()
        {
            Console.WriteLine();
        }
        public void Sleep()
        {
            Console.WriteLine();
        }
    }

    interface IWorkable
    {
        void Work();
    }

    interface IFeedable
    {
        void Eat();
    }

    interface ISleepable
    {
        void Sleep();
    }


    class Robot1 : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot is working");
        }
    }

}
