using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    class ConstReadonly
    {
        object x = 54;
        dynamic y = 45;

        public const int res = 89;
        readonly int z;
        // 
        int res1 = 890;

        public ConstReadonly(int x)
        {
            z = x;
        }
        public void M1()
        {
            // z = 56; //error here
            res1 = 34;

            var x = 34;
        }

        public void M2()
        {
            Console.WriteLine(res);
        }
    }
}
