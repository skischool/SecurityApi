using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainModule.Data;

namespace DistributedServices.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing Database...");

            var context = new DataContext();
            context.Database.Initialize(true);

            Console.WriteLine("Done...");
            Console.ReadLine();
        }
    }
}
