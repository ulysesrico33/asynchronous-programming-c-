using System;

namespace AsynchTest // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Task<int> result = LongProcess();
            Console.WriteLine("Ya se preparó la tarea");
            ShortProcess();
            var res = await result;
            Console.WriteLine($"Vaya, por fin :) . Resultado = {res}");
            Console.WriteLine("Mientras llega el resultado vamos por un café...");
           
        }

        static async Task<int> LongProcess()
        {
            Console.WriteLine("LongProcess Started");
            await Task.Delay(15000); 
            Console.WriteLine("LongProcess Completed");

            return 10;
       }

        static void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            //do something here

            Console.WriteLine("ShortProcess Completed");
        }
    }
}