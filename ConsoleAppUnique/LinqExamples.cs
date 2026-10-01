using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ConsoleAppUnique
{
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



        }
    }
}
