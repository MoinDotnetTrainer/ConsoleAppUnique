using ConsoleAppUnique.Solid;
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

            //try
            //{
            //    Props p = new Props();
            //    p.x_ = 23;  // paper 1 of 50 
            //    p.y_ = 34; // paper 2 of 50 marks
            //  //  Console.WriteLine(p.Add());

            //    p.ISAS();
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            //Console.ReadLine();

            // exe with the class name

            //DelegatesExample.Add();
            //DelegatesExample.Sub();
            //DelegatesExample.Mul(12, 2);
            //DelegatesExample.Div(1, 2);

            // executed thrw delegates
            // the del sign , method sign should be same


            //single cast
            // Single instance of del is invoke one method
            /* Cal1 c1 = new Cal1(DelegatesExample.Add);
             c1.Invoke();  // executer

             Cal1 c2 = new Cal1(DelegatesExample.Sub);
             c2.Invoke();

             Cal2 c3 = new Cal2(DelegatesExample.Mul);
             c3.Invoke(12, 2);

             Cal2 c4 = new Cal2(DelegatesExample.Div);
             c4.Invoke(12, 2);


             */
            // multi cast
            // washing 
            // Start is an executer , Timer , Spin , Soak , Wash  , dry


            /*  Cal1 c1multi = new Cal1(DelegatesExample.Add);
              c1multi += new Cal1(DelegatesExample.Sub);
              c1multi -= new Cal1(DelegatesExample.Sub);
              c1multi.Invoke();  // executer


              Cal2 c2multi = new Cal2(DelegatesExample.Mul);
              c2multi += new Cal2(DelegatesExample.Div);
              c2multi.Invoke(12, 2);  // executer


              Cal1 unnamed1 = delegate
              {
                  Console.WriteLine(" this is my unnamed fun , getted executed");
              };
              unnamed1.Invoke();

              Cal1 unnamed2 = () =>
              {
                  Console.WriteLine("Unnamed fun 2");
              };
              unnamed2.Invoke();

              Cal2 unnamed3 = (x, y) =>
              {
                  Console.WriteLine(x);
                  Console.WriteLine(y);
                  return x + y;
              };
              unnamed3.Invoke(12, 2);

              Action<string> act = (str) =>
              {
                  Console.WriteLine(str);

              };
              act.Invoke("hello");

              Func<int, int> res = (x) =>
              {
                  return x;
              };

              Console.WriteLine(res.Invoke(12));


              Func<int, int, int> func = (x, y) =>
              {
                  int z = x = y;
                  return z;
              };

              int result = func(10, 20);

              Console.WriteLine("Add is:" + result);


              Func<int, string> func1 = (x) =>
              {

                  if (x == 1)
                  {
                      return "hi";
                  }
                  return "NA";
              };

              Console.WriteLine(func1.Invoke(1));



              Predicate<int> number = (x) =>
              {
                  if (x == 12)
                  {
                      return true;
                  }
                  else

                  {
                      return false;
                  }
              };

              Console.WriteLine(number.Invoke(12));

              */

            //Generics.Add(12,2); 
            //// add works only with int

            //Generics.M1<int>(12);
            //Generics.M1<string>("hi");
            //Generics.M1<bool>(true);
            //Generics.M1<double>(23.34);


            //Generics.M2<int, int>(123,243);
            //Generics.M2<int, string>(123,"hi");
            //Generics.M2<string, int>("test",243);
            //Generics.M2<string, string>("Test","testing");


            // generics tool , in MVC 

            // Microsoft ,generics collections

            // CollExamples obj = new CollExamples();

            // obj.NonGen();



            //    AsyncAwait obj = new AsyncAwait();

            //    Task t = new Task(obj.Exeasync);
            //    t.Start();
            //    t.Wait();
            //    Console.ReadLine();


            //   LinqExamples.LinqEx();

            //Rectangle rect = new Square();
            //rect.Width = 5;
            //rect.Height = 10;

            //Console.WriteLine(rect.Area()); // Expected: 50,100

            //  IShape shape = new Square1(5);
            // Console.WriteLine(shape.Area()); // Always correct

            //            IShape rect = new Rectangle1(5,10);
            //           Console.WriteLine(rect.Area()); // Always correct


            Class2.M1();
            Class2.M2(6);

            // without debugging , we can see the output in console window
            // with debugging , we can see the output in output window  
            // flow of a program execution
        }






    }
}
