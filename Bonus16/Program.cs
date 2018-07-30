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
                if (choice == "N")
                {
                    break;
                }
            }

            foreach (Car e in cars)
            {
                Console.WriteLine($"{e.Make}, {e.Model}, {e.Year}, ${e.Price}");
                Console.WriteLine("========================================");
            }






            
        }
    }
}
