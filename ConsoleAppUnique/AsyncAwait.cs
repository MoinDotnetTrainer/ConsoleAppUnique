using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    public class AsyncAwait
    {
        public int ReturnCount(string Filename)
        {
            int len = 0;
            using (StreamReader reader = new StreamReader(Filename))
            {
                string content = reader.ReadToEnd(); // read total no words
                len += content.Length;
                Task.Delay(4000).Wait();  // for 3 seconds
            }

            return len;
        }
        public void Exe()
        {
            string filename = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\Desktop\\Myfile.txt";
            int Count = ReturnCount(filename);

            Console.WriteLine("Task1");
            Console.WriteLine("Task2");
            Console.WriteLine("Task3");
            Console.WriteLine("Task4");
            Console.WriteLine("Total No of Words:" + Count);  // 4 seconds
            Console.WriteLine("Task5");
            Console.WriteLine("Task6");
            Console.WriteLine("Task7");

        }
        // async , await
        public async Task<int> ReturnCountAsync(string Filename)
        {
            int len = 0;
            using (StreamReader reader = new StreamReader(Filename))
            {
                string content = await reader.ReadToEndAsync(); // read total no words
                len += content.Length;
                Task.Delay(4000).Wait();  // for 3 seconds
            }
            return len;
        }
        public async void Exeasync()
        {
            string filename = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\Desktop\\Myfile.txt";
            Task<int> Count = ReturnCountAsync(filename);

            Console.WriteLine("Task1");
            Console.WriteLine("Task2");
            Console.WriteLine("Task3");
            Console.WriteLine("Task4");
            int finres = await Count;
            Console.WriteLine("Total No of Words:" + finres);  // 4 seconds
            Console.WriteLine("Task5");
            Console.WriteLine("Task6");
            Console.WriteLine("Task7");

        }

    }
}
