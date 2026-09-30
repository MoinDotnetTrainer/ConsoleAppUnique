using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calci
    {
        int x, y, z;
        public int Add()
        { // calci class object
            x = 34;
            y = 43;
            z = x + y;
            return z;
        }

        public int Sub()
        {
            x = 34;
            y = 43;
            z = x - y;
            return z;
        }

        public int Mul()
        {
            x = 34;
            y = 43;
            z = x * y;
            return z;
        }
    }
}
