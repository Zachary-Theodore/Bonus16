using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            string[] header = { "Make", "Model", "Year", "Price" };
            while (true)
            {
                Console.Clear();
                Car temp = new Car();
                Console.WriteLine("Please Provide a Make:");
                temp.Make = (Console.ReadLine());
                Console.WriteLine("Please Provide a Model:");
                temp.Model = (Console.ReadLine());
                Console.WriteLine("Please Provide a Year:");
                temp.Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Provide a Price:");
                temp.Price = double.Parse(Console.ReadLine());

                cars.Add(temp);

                Console.WriteLine("Add another Vehicle?");
                string choice = Console.ReadLine();
                if (choice == "N" || choice == "n")
                {
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine($"{header[0], -10} {header[1], -10} {header[2], -10} {header[3], -10}");
            Console.WriteLine("______________________________________________________");
            foreach (Car e in cars)
            {
                Console.WriteLine($"{e.Make, -10} {e.Model, -10} {e.Year, -10} ${e.Price, -10}");
                Console.WriteLine("==================================================");
            }






            
        }
    }
}
