using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique.Solid
{

    // Open/Closed Principle (OCP) states that software entities (classes, modules, functions, etc.) should be open for extension but closed for modification. This means that the behavior of a module can be extended without modifying its source code.
    public class DiscountCalculator
    {
        public double CalculateDiscount(string customerType, double amount)
        {
            if (customerType == "Regular")
            {
                return amount * 0.1;
            }
            else if (customerType == "Premium")
            {
                return amount * 0.2;
            }
            else if (customerType == "VIP")
            {
                return amount * 0.3;
            }

            else if (customerType == "SelfStaff")
            {
                return amount * 0.4;
            }

            return 0;
        }
    }

    public interface IDiscount
    {
        double Calculate(double amount);
    }
    public class RegularDiscount : IDiscount
    {
        public double Calculate(double amount)
        {
            return amount * 0.1;
        }
    }

    public class PremiumDiscount : IDiscount
    {
        public double Calculate(double amount)
        {
            return amount * 0.2;
        }
    }

    public class VipDiscount : IDiscount
    {
        public double Calculate(double amount)
        {
            return amount * 0.3;
        }
    }

    public class SelfStaffDiscount : IDiscount
    {
        public double Calculate(double amount)
        {
            return amount * 0.4;
        }
    }



}
