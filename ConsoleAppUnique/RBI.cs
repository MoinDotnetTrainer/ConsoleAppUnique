using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    public class RBI
    {
        public virtual void Withdraw()
        {
            Console.WriteLine("BL for RBI to get Withdraw amount");
        }
        public virtual void Deposite()
        {
            Console.WriteLine("BL for RBI to get Deposite amount");
        }

        public void Employees()
        {
            Console.WriteLine("BL for RBI Emp");
        }
    }

    public class SBI : RBI
    {
        public override void Withdraw()
        {
            Console.WriteLine("BL for SBI to get Withdraw amount");
        }
        public new   void Deposite()  // inde sbi
        {
            Console.WriteLine("BL for SBI to get Deposite amount");
        }

        public void MyStaff()
        {
            Console.WriteLine("BL for SBI staff");
        }

    }
}
