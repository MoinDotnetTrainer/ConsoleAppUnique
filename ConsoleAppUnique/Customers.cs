using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    public class Customers
    {
        public int CustID;
        public string CustName;
    }

    public class Orders : Customers
    {
        string OrderName;
        public void OrderDetails()
        {
            OrderName = "Pizza";
            CustID = 1;
            CustName = "xyz";

            OrderName = "Burger";
            CustID = 2;
            CustName = "abc";
        }
    }



    public class AddOps()
    {
        protected int x, y, z;
        protected void Add()
        {
            x = 45;
            y = 354;
            z = x + y;
            Console.WriteLine(z);
        }
    } // ends here

    public class MulOps : AddOps
    {
        public void Mul()
        {
            Add();
            x = 45;
            y = 354;
            z = x * y;
            Console.WriteLine(z);
        }
    }

    public class SubOps : AddOps
    {
        public void Mul()
        {
            Add();
            x = 45;
            y = 354;
            z = x - y;
            Console.WriteLine(z);
        }
    }


}
