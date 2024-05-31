using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop japanShop = new Shop("Japan Car Shop.");
            Shop luxuryShop = new Shop("Luxury Car Shop.");

            Cars toyota = new Cars("Toyota");
            toyota.AddModelsAndPrices("Corolla", 20000);
            toyota.AddModelsAndPrices("Tacoma", 55000);
            toyota.AddModelsAndPrices("Celica", 40000);
            toyota.AddModelsAndPrices("Supra", 75000);

            Cars mitsubishi = new Cars("Mitsubishi");
            mitsubishi.AddModelsAndPrices("Eclipse", 30000);
            mitsubishi.AddModelsAndPrices("GTO", 80000);
            mitsubishi.AddModelsAndPrices("Galant", 15000);
            mitsubishi.AddModelsAndPrices("Colt", 12000);

            Cars nissan = new Cars("Nissan");
            nissan.AddModelsAndPrices("Sentra", 23000);
            nissan.AddModelsAndPrices("Micra", 10000);
            nissan.AddModelsAndPrices("GTR", 100000);
            nissan.AddModelsAndPrices("Titan", 90000);

            Cars honda = new Cars("Honda");
            honda.AddModelsAndPrices("Civic", 16000);
            honda.AddModelsAndPrices("CRX", 19000);
            honda.AddModelsAndPrices("NSX", 95000);
            honda.AddModelsAndPrices("S2000", 65000);

            Cars bmw = new Cars("BMW");
            bmw.AddModelsAndPrices("M5", 170000);
            bmw.AddModelsAndPrices("M3", 150000);
            bmw.AddModelsAndPrices("M8", 250000);
            bmw.AddModelsAndPrices("X6M", 175000);

            Cars astonmartin = new Cars("Aston Martin");
            astonmartin.AddModelsAndPrices("Rapid S", 200000);
            astonmartin.AddModelsAndPrices("DBX", 250000);
            astonmartin.AddModelsAndPrices("Vanquish", 300000);
            astonmartin.AddModelsAndPrices("One-77", 2000000);

            Cars ferrari = new Cars("Ferrari");
            ferrari.AddModelsAndPrices("F40", 1500000);
            ferrari.AddModelsAndPrices("F12 Berlinetta", 250000);
            ferrari.AddModelsAndPrices("GTC4Lusso", 200000);
            ferrari.AddModelsAndPrices("Purosangue", 260000);

            Cars audi = new Cars("Audi");
            audi.AddModelsAndPrices("RS7", 110000);
            audi.AddModelsAndPrices("S8", 140000);
            audi.AddModelsAndPrices("R8", 200000);
            audi.AddModelsAndPrices("RSQ8", 170000);

            japanShop.AddCars(toyota);
            japanShop.AddCars(mitsubishi);
            japanShop.AddCars(nissan);
            japanShop.AddCars(honda);
            luxuryShop.AddCars(bmw);
            luxuryShop.AddCars(astonmartin);
            luxuryShop.AddCars(ferrari);
            luxuryShop.AddCars(audi);

            Console.WriteLine("Please select what would you like to do: ");
            Console.WriteLine("Enter 1 if you want to list every car shop from the city.");
            Console.WriteLine("Enter 2 if you want to see what cars are on sale.");
            Console.WriteLine("Enter 3 if you want to see the cheapest car for sale.");
            Console.WriteLine("Enter 4 if you want to see the most expensive car for sale.");
            Console.WriteLine("Press Enter if you want to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Car shops in the city. Which one would you like to choose: ");
                        Console.WriteLine("1 " + japanShop.Name);
                        Console.WriteLine("2 " + luxuryShop.Name);

                        string shopSelection = Console.ReadLine();

                        if (shopSelection == "1")
                        {
                            Console.WriteLine("Welcome to the Japan Car Shop. Which brand would you like to choose: ");
                            japanShop.ListCars();
                            string carSelection = Console.ReadLine().ToLower();

                            if(carSelection == "toyota")
                            {
                                Console.WriteLine("This is our selection from the Toyota: ");
                                toyota.ListModelsAndPrices();

                                string modelSelection = Console.ReadLine().ToLower();

                                toyota.SelectModel(modelSelection);
                            }

                            else if (carSelection == "mitsubishi")
                            {
                                Console.WriteLine("This is our selection from the Mitsubishi: ");
                                mitsubishi.ListModelsAndPrices();

                                string modelSelection = Console.ReadLine().ToLower();
   
                                mitsubishi.SelectModel(modelSelection);
                            }

                            else if (carSelection == "nissan")
                            {
                                Console.WriteLine("This is our selection from the Nissan: ");
                                nissan.ListModelsAndPrices();

                                string modelSelection = Console.ReadLine().ToLower();

                                nissan.SelectModel(modelSelection);
                            }

                            else if (carSelection == "honda")
                            {
                                Console.WriteLine("This is our selection from the Honda: ");
                                honda.ListModelsAndPrices();

                                string modelSelection = Console.ReadLine().ToLower();
                                
                                honda.SelectModel(modelSelection);
                            }

                            else
                            {
                                Console.WriteLine("Invalid selection. Please try again.");
                            }

                        }
                        else if (shopSelection == "2")
                        {
                            Console.WriteLine("Welcome to the Luxury Car Shop. Which brand would you like to choose: ");
                            luxuryShop.ListCars();
                            string carSelection = Console.ReadLine().ToLower();
                            if (carSelection == "bmw")
                            {
                                Console.WriteLine("This is our selection from the Toyota: ");
                                bmw.ListModelsAndPrices();

                                string modelSelection = Console.ReadLine().ToLower();
                                
                                bmw.SelectModel(modelSelection);
                            }

                            else if (carSelection == "aston martin")
                            {
                                Console.WriteLine("This is our selection from the Mitsubishi: ");
                                astonmartin.ListModelsAndPrices();

                                string modelSelection = Console.ReadLine().ToLower();
                                
                                astonmartin.SelectModel(modelSelection);
                            }

                            else if (carSelection == "ferrari")
                            {
                                Console.WriteLine("This is our selection from the Nissan: ");
                                ferrari.ListModelsAndPrices();

                                string modelSelection = Console.ReadLine().ToLower();
                                
                                ferrari.SelectModel(modelSelection);
                            }

                            else if (carSelection == "audi")
                            {
                                Console.WriteLine("This is our selection from the Honda: ");
                                audi.ListModelsAndPrices();

                                string modelSelection = Console.ReadLine().ToLower();
                                
                                audi.SelectModel(modelSelection);
                            }

                            else
                            {
                                Console.WriteLine("Invalid selection. Please try again.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid selection. Please try again.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Cars on sale in the Japan Car Shop:");
                        japanShop.ListCars();
                        Console.WriteLine("Cars on sale in the Luxury Car Shop:");
                        luxuryShop.ListCars();
                        break;

                    case "3":
                        Console.WriteLine("The cheapest car for sale:");
                        int cheapestJapanCar = japanShop.CheapestCar();
                        int cheapestLuxuryCar = luxuryShop.CheapestCar();
                        int cheapestCar = Math.Min(cheapestJapanCar, cheapestLuxuryCar);
                        Console.WriteLine($"The cheapest car is priced at {cheapestCar} $");
                        break;

                    case "4":
                        Console.WriteLine("The most expensive car for sale:");
                        int mostExpensiveJapanCar = japanShop.MostExpensiveCar();
                        int mostExpensiveLuxuryCar = luxuryShop.MostExpensiveCar();
                        int mostExpensiveCar = Math.Max(mostExpensiveJapanCar, mostExpensiveLuxuryCar);
                        Console.WriteLine($"The most expensive car is priced at {mostExpensiveCar} $");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
