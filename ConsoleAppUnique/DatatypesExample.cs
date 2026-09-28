using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    internal class DatatypesExample
    {
        public void Ex()
        {

            // signed unsigned

            //1 byte
            byte b = 255;  // unsigned +ve
            sbyte sb = 23; // signed -+ 


            // 2 byte
            short s = 234;
            ushort us = 4535;

            //int 4
            int i = 345;
            uint ui = 4;


            // 8 
            long l = 34;
            ulong ul = 234;

            // float  0.00
            // float , double & decimal
            float f = 2345.3f;
            double d_ = 23345.54;
            decimal dm = 23.65m;

            // bool
            bool status = true;

            string str = "xyz";
            string email = "xyz@yahoo.com";

            char c = 'A';

            // other categories --> other lang
            // var dynamic & object


            //compile
            var v = 34;
            v = 346;
            v = 35;
            v = 356;


            Console.WriteLine(v);
            var v1 = 234.34;

            var v2 = "Hi";

            var v3 = true;



            // runtime ,, value type
            dynamic d = 34;
            d = 25.5;
            d = "";
            d = true;
            Console.WriteLine(d);
            dynamic d1 = 234.34;
            dynamic d2 = "hi";
            dynamic d3 = true;
            dynamic res = d + d1;



            // run time  ,, ref type
            object o = 34;
            o = 234.345;
            o = "Hi";
            object o1 = "hi";
            object o2 = 45.34;
            object o3 = true;
            object res1 = (int)o + (int)o2;  // type cast --> ref to value


            string res2 = "10" + "12";
            // 10+12 = 22
            Console.WriteLine(res2);//1012


            Console.WriteLine(o);
        }
    }
}
