using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "white", 1, 100, "electric", 5);
            Car Opel = new Car("Astra", "blue", 2020, 120);
            Car Dacia = new Car("Logan");
            Ford.Display();
            Opel.Display();
            Console.WriteLine(Dacia.Name);
            Console.WriteLine();
            Ford.honk();
            Console.ReadKey();
        }
    }
}
