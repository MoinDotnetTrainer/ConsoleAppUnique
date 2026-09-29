using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    public class ExceptionHandling
    {
        // error are of 2 types
        // compile and runtime
        // runtime unexpe

        public void test()
        {
        a:
            try
            {
                Console.WriteLine(" Enter x:");
                int x = Convert.ToInt32(Console.ReadLine()); // kjgjg

                Console.WriteLine(" Enter y:");
                int y = Convert.ToInt32(Console.ReadLine());

                int z = x / y;
                Console.WriteLine("Div is :" + z);


                int[] arr = { 34 };

                Console.WriteLine(arr[10]); // what error we get here

                string str = null;
                Console.WriteLine(str.Length); // error 
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto a;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                goto a;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto a;
            }

        }
    }
}
