using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ConsoleAppUnique
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
    }
    internal class LinqExamples
    {
        public static void LinqEx()
        {
            List<Student> students = new List<Student>
        {
            new Student
            {
                ID = 1,Name = "Rahul",Email="rahul@yahoo.com",Gender = "Male",Branch = "CSE",Age = 22
            },
            new Student
            {
                ID = 2,Name = "Priya",Email="priya@yahoo.com",Gender = "Female",Branch = "ECE",Age = 22
            },
            new Student
            {
                ID = 3,Name = "Arjun",Email="arjun@yahoo.com",Gender = "Male",Branch = "IT",Age = 22
            },
              new Student
            {
                ID = 4,Name = "xyz",Email="xyz@yahoo.com",Gender = "Male",Branch = "IT",Age = 22
            }
        };

            List<Student> students1 = new List<Student>
        {
            new Student
            {
                ID = 4,Name = "test",Gender = "Male",Branch = "CSE",Age = 20
            },
            new Student
            {
                ID = 5,Name = "testing",Gender = "Female",Branch = "ECE",Age = 21
            },
            new Student
            {
                ID = 3,Name = "Arjun",Gender = "Male",Branch = "IT",Age = 22
            },
              new Student
            {
                ID = 4,Name = "xyz",Gender = "Male",Branch = "IT",Age = 22
            }
        };

            int[] arr = { 234, 5645, 64, 75, 67, 78, 6786, 7897, 890, 890, 80, 9, 45, 6, 656 };
            List<int> list = new List<int> { 235, 5, 54, 667, 5, 7867, 879, 78, 97, 0, 567, 57, 6 };

            // extract from this coll using LINQ
            // Select * from tblName

            // multiple source
            var res = from s in arr select s;
            // same extract from multiple source


            var res1 = from s in arr where s > 50 select s;
            var res2 = from s in arr where s < 50 select s;
            var res3 = from s in arr where s == 50 select s;
            foreach (var item in res2)
            {
                //Console.WriteLine(item);
            }

            var res4 = from s in students select s;
            var res5 = from s in students where s.Age > 20 select s;
            var res6 = from s in students where s.Name == "Rahul" select s;
            var res7 = from s in students
                       select new Student
                       {
                           Name = s.Name,
                           Age = s.Age
                       };





            foreach (var item in res7)
            {
                // Console.WriteLine($"Id is {item.ID} Name is {item.Name} Gender is {item.Gender} branch is {item.Branch} Age is {item.Age}");
            }
            //Console.WriteLine("foreach");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            object[] obj = { 234, 345, 456, 45, "Hi", "hello", 234, 34, 234.34, 345.356, true, false };

            var res8 = obj.OfType<string>().ToList();
            foreach (var item in res8)
            {
                //   Console.WriteLine(item);
            }


            int[] arr1 = { 101, 101, 234, 5645, 234, 5645, 64, 75, 67, 78, 6786, 7897, 890, 890, 80, 9, 45, 6, 656 };


            var res9 = (from s in arr1 select s).Distinct();

            var res10 = (from s in arr1 select s).DistinctBy(x => x > 100);

            var res11 = (from s in students select s).DistinctBy(x => x.Age);
            foreach (var item in res11)
            {
                //  Console.WriteLine($"Id is {item.ID} Name is {item.Name} Gender is {item.Gender} branch is {item.Branch} Age is {item.Age}");
            }


            var max = (from s in arr1 select s).Max();
            var min = (from s in arr1 select s).Min();
            var sum = (from s in arr1 select s).Sum();


            var maxby = (from s in students select s).MaxBy(x => x.Age);
            //   Console.WriteLine(maxby.Name);



            int[] s1 = { 234324, 5, 35, 4, 656, 75, 867, 878, 978, 98, 089, 080, 90 };
            int[] s2 = { 234324, 5, 35, 4, 656, 98, 089, 080, 90, 35, 56, 46, 567, 58, 678 };

            var union = s1.Union(s2);
            var concat = s1.Concat(s2);
            var Intersect = s1.Intersect(s2);
            var except = s1.Except(s2);
            foreach (var item in except)
            {
                //  Console.WriteLine(item);
            }


            var unionby = students.UnionBy(students1, x => x.ID).ToList();
            foreach (var item in unionby)
            {
                // Console.WriteLine($"Id is {item.ID} Name is {item.Name} Gender is {item.Gender} branch is {item.Branch} Age is {item.Age}");
            }



            // all any & contains --> TF

            int[] arr2 = { 101, 101, 234, 5645, 234, 5645, 64, 75, 67, 78, 6786, 7897, 890, 890, 80, 9, 45, 6, 656 };


            var allex = (from s in arr2 select s).All(x => x > 0);
            // TF 
            //Console.WriteLine(allex);


            var allex1 = (from Student s in students select s).All(x => x.Name == "Rahul" && x.Email == "rahul@yahoo.com");
            var allex2 = (from Student s in students select s).All(x => x.Age == 22);

            var anyex = (from s in arr2 select s).Any(x => x > 1000);
            var anyex1 = (from Student s in students select s).Any(x => x.Name == "Rahul" && x.Email == "rahul@yahoo.com");

            var contains = (from s in arr2 select s).Contains(-100);

            //Console.WriteLine(contains);  // Rahul , Rahul@yahoo.com



            // elements the can be fixed using

            int[] arr3 = { 101, 101, 234, 5645, 234, 5645, 64, 75, 67, 78, 6786, 7897, 890, 890, 80, 9, 45, 6, 656 };

            var ele = (from s in arr3 select s).ElementAt(3);
            var eledf = (from s in arr3 select s).ElementAtOrDefault(2344);

            var first = (from s in arr3 select s).First(x => x < 50);
            var firstdef = (from s in arr3 select s).FirstOrDefault(x => x < 0);
            //Console.WriteLine(firstdef);


            var std = students.Where(x => x.Name == "Rahul").FirstOrDefault();
            //  Console.WriteLine(std.Age);

            var last = (from s in arr3 select s).Last();
            var lastex = (from s in arr3 select s).Last(x => x < 40);
            var lastdef = (from s in arr3 select s).FirstOrDefault(x => x < 0);



            int[] arr4 = { 23, 34 };
            // var single = (from s in arr4 select s).Single();
            var singleex = (from s in arr4 select s).Single(x => x == 34);
            //  Console.WriteLine(singleex);

            int[] arr5 = { 101, 101, 34, 3, 2, 34, 3, 234, 5645, 234, 5645, 64, 75, 67, 78, 6786, 7897, 890, 890, 80, 9, 45, 6, 656 };

            var take = (from s in arr5 select s).Take(5);
            var skip = (from s in arr5 select s).Skip(5);

            var takewhile = (from s in arr5 select s).TakeWhile(x => x > 50); // till the cond is true
            var skipwhile = (from s in arr5 select s).SkipWhile(x => x > 50);
            foreach (var item in skipwhile)
            {
                //Console.WriteLine(item);
            }


            List<Employee> employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Ravi",LName="xyz",  Department = "IT",      Salary = 60000 },
    new Employee { Id = 2, Name = "Priya",LName="xyz",  Department = "HR",      Salary = 50000 },
    new Employee { Id = 3, Name = "Arun", LName="xyz",  Department = "IT",      Salary = 75000 },
    new Employee { Id = 4, Name = "Sneha",LName="xyz",  Department = "HR",      Salary = 55000 },
    new Employee { Id = 5, Name = "Kiran",LName="xyz",  Department = "Finance", Salary = 65000 },
    new Employee { Id = 6, Name = "Anil", LName="xyz",  Department = "IT",      Salary = 50000 }
};


            var orderby = from s in employees orderby s.Salary select s;
            var orderbydesc = from s in employees orderby s.Salary descending select s;

            var thenby = employees.OrderBy(x => x.Id).ThenBy(x => x.Salary).ThenByDescending(x => x.Department);
            foreach (var item in thenby)
            {
                // Console.WriteLine($"Id is {item.Id} name is {item.Name} dept is {item.Department} sal is {item.Salary}");
            }


            var groupby = from s in employees group s by s.Department;
            var lookup = employees.ToLookup(x => x.Department);

            foreach (var item in lookup)
            {
              // Console.WriteLine($"Department is {item.Key}");

                foreach (var data in item)
                {
                 //   Console.WriteLine($"Id is {data.Id} name is {data.Name} dept is {data.Department} sal is {data.Salary}");
                }
            }


            // immediate execution 
            // lazy execution

            List<Employee> employees1 = new List<Employee>
{
    new Employee { Id = 1, Name = "Ravi",LName="xyz",  Department = "IT",      Salary = 60000 },
    new Employee { Id = 2, Name = "Priya",LName="xyz",  Department = "HR",      Salary = 50000 },
    new Employee { Id = 3, Name = "Arun", LName="xyz",  Department = "IT",      Salary = 75000 },
    new Employee { Id = 4, Name = "Sneha",LName="xyz",  Department = "HR",      Salary = 55000 },
    new Employee { Id = 5, Name = "Kiran",LName="xyz",  Department = "Finance", Salary = 65000 },
    new Employee { Id = 6, Name = "Anil", LName="xyz",  Department = "IT",      Salary = 50000 }
};


            var lazy = from s in employees1 where s.Salary > 60000 select s; // not start
            // all the emp
            var imm = (from s in employees1 where s.Salary > 60000 select s).Count();  // starts ends here
            // count

            employees1.Add(new Employee { Id = 7, Name = "xyz", LName = "abc", Department = "IT", Salary = 70000 });



            foreach (var item in lazy)  // 3  // exe starts
            {
                 Console.WriteLine($"Id is {item.Id} name is {item.Name} dept is {item.Department} sal is {item.Salary}");
            }


            Console.WriteLine(imm);  // 2



        }
    }
}