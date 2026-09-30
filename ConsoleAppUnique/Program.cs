using System.Diagnostics;

namespace ConsoleAppUnique
{
    internal class Program
    {
        static void Main(string[] args)  // entry point
        {
            //System.Console.WriteLine("Hello, World!");

            //Console.WriteLine("Hello, World!");

            // Sample s = new Sample(); // object creation
            // s.Userdetails();
            // s.Family();
            // s.Collegues();
            // s.Project();


            //DatatypesExample obj = new DatatypesExample();
            //obj.Ex();

            // Readline obj = new Readline();
            // obj.test();


            // new all to mysample class

            //  MySample obj = new MySample();
            // obj.test();

            /*Operations ops = new Operations();
            ops.Add();
            ops.Sub(22, 2);
            ops.Sub(y: 10, x: 20);
            ops.Sub(1);
            int res = ops.Mul(122, 2); // 24
            if (res == 24)
            {
                Console.WriteLine(" so this task");
            }
            else
            {
                Console.WriteLine("do that");
            }

            ops.Opspm(23, 32435, 234, 34, 54);

            Operations.M1();

            // single memory allocation , instd of mult
            *
            *
            */

            //  Constr c = new Constr();
            // c.M1(12);

            //StaticClass.m1(12);

            //ConstReadonly obj = new ConstReadonly(12);
            //obj.M2();
            //ConstReadonly obj1 = new ConstReadonly(122);
            //obj1.M2();

            //MulOps obj = new MulOps();
            //obj.Mul();
            //obj.Add();

            //RBI rbi = new RBI();
            //rbi.Withdraw();

            //SBI sbi = new SBI();
            //sbi.Deposite();


            //Products obj = new Products();
            //obj.prosales();
            //obj.ProductsDetails();
            //obj.ProExpDate(); // extended
            //obj.ProProfit();  // exteded



            //Emp emp = new Emp();
            //emp.EmpSal();
            //emp.EmpDetails();
            //emp.EmpProjectDetails();

            // ExceptionHandling obj = new ExceptionHandling();
            // obj.test();

            //RefOut obj = new RefOut();
            ////  obj.Exe();
            //obj.Ops4(12, 2, out int add, out int sub, out int mul);
            //if (add == 14)
            //{
            //    Console.WriteLine("do this");
            //}
            //Console.WriteLine(add);
            //Console.WriteLine(sub);
            //Console.WriteLine(mul);

            try
            {
                Props p = new Props();
                p.x_ = 23;  // paper 1 of 50 
                p.y_ = 34; // paper 2 of 50 marks
              //  Console.WriteLine(p.Add());

                p.ISAS();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }
    }
}
