using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public delegate void Cal1();
public delegate int Cal2(int x, int y);

namespace ConsoleAppUnique
{
    public class DelegatesExample
    {
        public static void Add() {
            Console.WriteLine(" add task");
        }
        public static void Sub()
        {
            Console.WriteLine(" Sub task");
        }

        public static int Mul(int x, int y)
        {
            Console.WriteLine(" mul task");
            return 1;
        }

        public static int Div(int x, int y)
        {
            Console.WriteLine(" div task");
            return 1;
        }
    }
}
