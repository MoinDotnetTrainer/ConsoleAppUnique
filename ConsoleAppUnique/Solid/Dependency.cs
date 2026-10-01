using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique.Solid
{

    // high level class , should not depend low level class
    // Both should depend on abstraction    

    class MySqlDatabase // low level , my sql 
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to MySQL database");

            // in my sql db
        }
    }

    class UserService1
    {
        private MySqlDatabase _database;

        public UserService1()
        {
            _database = new MySqlDatabase(); // ❌ direct dependency
        }

        public void AddUser(string name)
        {
            _database.Save(name); // High-level depends on low-level
        }
    }



    interface IDatabase
    {
        void Save(string data);
    }

    class MySqlDatabase1 : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to MySQL database");
        }
    }

    class MSSqlServerDatabase : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to SQL Server database");
        }
    }

    class UserService2
    {
        private IDatabase _database;

        // Dependency Injection
        public UserService2(IDatabase database)
        {
            _database = database;
        }

        public void AddUser(string name)
        {
            _database.Save(name); // only depends on abstraction
        }
    }


}
