using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;
using System.Threading;

namespace OwinSelfHosted
{
    public class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:9000/";
            WebApp.Start<Startup>(url: baseAddress);
            var spin = new ConsoleSpinner();
            Console.Write("RESTFUL OWIN is running");
            while (true)
            {
                spin.Turn();
            }

            //// Start OWIN host 
            //using (WebApp.Start<Startup>(url: baseAddress))
            //{
            //    // Create HttpCient and make a request to api/values 
            //    HttpClient client = new HttpClient();

            //    var response = client.GetAsync(baseAddress + "api/example").Result;

            //    Console.WriteLine(response);
            //    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            //}

            Console.ReadLine();
        }
    }

    public class ConsoleSpinner
    {
        int counter;

        public void Turn()
        {
            counter++;
            switch (counter % 4)
            {
                case 0: Console.Write("/"); counter = 0; break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
}