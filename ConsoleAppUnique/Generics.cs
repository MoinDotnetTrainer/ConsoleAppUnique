using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{

    public class Std
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Generics
    {

        //add method , datatype as an argumet
        public static void Add(int x, int y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        // generic method uses type as an argument , insted datatype

        public static void M1<type1>(type1 x)
        {
            Console.WriteLine(x);
        }

        public static void M2<t1, t2>(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public static void M3<t1, t2, t3>(t1 x, t2 y, t3 z)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }


    public class CollExamples
    {
        // array --> arr  is a similar datatype
        // len , 



        public void List()
        {
            int[] arr = { 243, 345 };
            int[] arr1 = new int[5] { 234, 345, 46, 46, 6 };
            // Data Manuplication , insert elelemnt , delete , search , sort -->DSA

            // coll are dynamic array , no lenth , Used DSA --> bL in simple methods
            // coll are using a gen

            // gen , non gen

            // 1 . gen coll
            // list , hashset ,sortedset, stack , queue , liniked list


            List<Std> std = new List<Std>();
            std.Add(new Std { ID = 1, Name = "xyz", Gender = "Male" });
            std.Add(new Std { ID = 2, Name = "abc", Gender = "Female" });
            std.Add(new Std { ID = 3, Name = "pqr", Gender = "Male" });
            std.Add(new Std { ID = 4, Name = "test", Gender = "Male" });

            foreach (var item in std)
            {
                Console.WriteLine($"Id is {item.ID} name is {item.Name} Gender is {item.Gender}");
            }

            List<string> str = new List<string>();
            List<int> list = new List<int>();
            list.Add(325);
            list.Add(123);
            list.Add(5);
            list.Add(56);
            list.Add(34);
            list.Add(54);
            list.Add(5);
            list.Add(325);
            list.Add(123);
            list.Add(5);
            list.Add(56);
            list.Add(34);
            list.Add(54);
            list.Add(5);
            list.Add(34);
            list.Add(45);
            list.Add(7);
            list.Add(587);
            list.Add(56);
            list.Add(34);
            list.Add(54);
            list.Add(5);
            list.Add(34);
            list.Remove(5);  // element
            list.RemoveAt(0); // index
            list.Insert(0, 123);


            for (int i = 0; i < arr.Length; i++)
            {

            }

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void Hashset()
        {
            HashSet<int> ints = new HashSet<int>();
            ints.Add(324);
            ints.Add(67);
            ints.Add(567);
            ints.Add(67);
            ints.Add(324);
            ints.Add(67);
            ints.Add(324);
            ints.Add(324);
            ints.Add(67);
            ints.Add(567);
            ints.Add(67);
            ints.Add(324);
            ints.Add(67);
            ints.Add(324);
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }

        public void sortedset()
        {
            SortedSet<int> ints = new SortedSet<int>();
            ints.Add(324);
            ints.Add(67);
            ints.Add(567);
            ints.Add(67);
            ints.Add(324);
            ints.Add(67);
            ints.Add(324);
            ints.Add(324);
            ints.Add(67);
            ints.Add(567);
            ints.Add(67);
            ints.Add(324);
            ints.Add(67);
            ints.Add(324);
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }

        public void NonGen()
        {
            ArrayList arr = new ArrayList();
            arr.Add(23);
            arr.Add(345);
            arr.Add(45);
            arr.Add(2563);
            arr.Add("hi");
            arr.Add(true);
            arr.Add(56.345);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
