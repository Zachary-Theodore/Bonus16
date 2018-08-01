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
            Console.WriteLine("Choose a car from the list:(1-6)");
            Console.WriteLine();
            Car c1 = new Car("BMW", "325i", "2018", 45000);
            Car c2 = new Car("Subaru", "WRX STi", "2018", 35000);
            Car c3 = new Car("Mazda", "RX-8", "2018", 41000);
            Used u1 = new Used("Ford", "Fiesta RS", "2005", 10000, 63000);
            Used u2 = new Used("Toyota", "AE 86", "1986", 7500, 130000);
            Used u3 = new Used("Mazda", "Miata", "2000", 17000, 58000);

            List<Car> carList = new List<Car>() { c1, c2, c3, u1, u2, u3 };

            List<string> header = new List<string>()
            {"Make","Model","Year","Price" };

            Console.WriteLine($"{header[0],-15}{header[1],-15}{header[2],-15}{header[3],-15}");
            Console.WriteLine("____________________________________________________________");
            foreach (Car c in carList) 
            {
                Console.WriteLine($"{c.Make,-15}{c.Model,-15}{c.Year,-15}{c.Price,-15}");
            }

            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice >=1 && userChoice <=3 )
            {
                Console.WriteLine("Here is the informartion for this new car: ");
                carList[userChoice - 1].PrintInfo();
                Console.WriteLine("Would you like to buy this Vehicle?(Y/N)");

            }

            

            //while (true)
            //{
            //    Console.Clear();
            //    Car temp = new Car();
            //    Console.WriteLine("Please Provide a Make:");
            //    temp.Make = (Console.ReadLine());
            //    Console.WriteLine("Please Provide a Model:");
            //    temp.Model = (Console.ReadLine());
            //    Console.WriteLine("Please Provide a Year:");
            //    temp.Year = Console.ReadLine();
            //    Console.WriteLine("Please Provide a Price:");
            //    temp.Price = double.Parse(Console.ReadLine());

            //    cars.Add(temp);

            //    Console.WriteLine("Add another Vehicle?");
            //    string choice = Console.ReadLine();
            //    if (choice == "N" || choice == "n")
            //    {
            //        break;
            //    }
            //}
            //Console.Clear();
            //Console.WriteLine($"New Cars -{header[0], -10} {header[1], -10} {header[2], -10} {header[3], -10}");
            //Console.WriteLine("________________________________________________________________");
            //foreach (Car e in cars)
            //{
            //    Console.WriteLine($"          {e.Make, -10} {e.Model, -10} {e.Year, -10} ${e.Price, -10}");
            //    Console.WriteLine("============================================================");
            //}






            
        }
    }
}
