using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique.Solid
{
    internal class UserService
    {
        public void RegisterUser(string username, string email)
        {
            // Validation
            if (string.IsNullOrEmpty(username))
                throw new Exception("Username is required");

            if (!email.Contains("@"))
                throw new Exception("Invalid email");

            // Save to database
            Console.WriteLine("Saving user to database...");

            // Send email
            Console.WriteLine("Sending welcome email...");
        }


        public void SaveData() { }

        public void SendEmail() { }
    }


    public class UserValidator
    {
        public void Validate(string username, string email)
        {
            if (string.IsNullOrEmpty(username))
                throw new Exception("Username is required");

            if (!email.Contains("@"))
                throw new Exception("Invalid email");
        }
    }

    public class UserRepository
    {
        public void Save(string username, string email)
        {
            Console.WriteLine("Saving user to database...");
        }
    }
    public class EmailService
    {
        public void SendWelcomeEmail(string email)
        {
            Console.WriteLine("Sending welcome email...");
        }
    }

}
