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
            List<Purchase> purchases = new List<Purchase>();

            Shop japanShop = new Shop("Japan Car Shop.");
            Shop luxuryShop = new Shop("Luxury Car Shop.");

            Cars toyota = new Cars("Toyota");
            toyota.AddModelsAndPrices("Corolla", 20000);
            toyota.AddModelsAndPrices("Tacoma", 55000);
            toyota.AddModelsAndPrices("Celica", 40000);
            toyota.AddModelsAndPrices("Supra", 75000);
            toyota.AddColors("Corolla", new List<string> { "Red", "Blue", "White" });
            toyota.AddColorSurcharge("Corolla", "Red", 500);
            toyota.AddColors("Tacoma", new List<string> { "Black", "Silver", "Grey" });
            toyota.AddColorSurcharge("Tacoma", "Black", 1000);
            toyota.AddColors("Celica", new List<string> { "Yellow", "Green", "Blue" });
            toyota.AddColorSurcharge("Celica", "Yellow", 700);
            toyota.AddColors("Supra", new List<string> { "Red", "Black", "White" });
            toyota.AddColorSurcharge("Supra", "Black", 1500);

            Cars mitsubishi = new Cars("Mitsubishi");
            mitsubishi.AddModelsAndPrices("Eclipse", 30000);
            mitsubishi.AddModelsAndPrices("GTO", 80000);
            mitsubishi.AddModelsAndPrices("Galant", 15000);
            mitsubishi.AddModelsAndPrices("Colt", 12000);
            toyota.AddColors("Eclipse", new List<string> { "Red", "Blue", "White" });
            toyota.AddColorSurcharge("Eclipse", "Red", 500);
            toyota.AddColors("GTO", new List<string> { "Black", "Silver", "Grey" });
            toyota.AddColorSurcharge("GTO", "Black", 1000);
            toyota.AddColors("Galant", new List<string> { "Yellow", "Green", "Blue" });
            toyota.AddColorSurcharge("Galant", "Yellow", 700);
            toyota.AddColors("Colt", new List<string> { "Red", "Black", "White" });
            toyota.AddColorSurcharge("Colt", "Black", 1500);

            Cars nissan = new Cars("Nissan");
            nissan.AddModelsAndPrices("Sentra", 23000);
            nissan.AddModelsAndPrices("Micra", 10000);
            nissan.AddModelsAndPrices("GTR", 100000);
            nissan.AddModelsAndPrices("Titan", 90000);
            toyota.AddColors("Sentra", new List<string> { "Red", "Blue", "White" });
            toyota.AddColorSurcharge("Sentra", "Red", 500);
            toyota.AddColors("Micra", new List<string> { "Black", "Silver", "Grey" });
            toyota.AddColorSurcharge("Micra", "Black", 1000);
            toyota.AddColors("GTR", new List<string> { "Yellow", "Green", "Blue" });
            toyota.AddColorSurcharge("GTR", "Yellow", 700);
            toyota.AddColors("Titan", new List<string> { "Red", "Black", "White" });
            toyota.AddColorSurcharge("Titan", "Black", 1500);

            Cars honda = new Cars("Honda");
            honda.AddModelsAndPrices("Civic", 16000);
            honda.AddModelsAndPrices("CRX", 19000);
            honda.AddModelsAndPrices("NSX", 95000);
            honda.AddModelsAndPrices("S2000", 65000);
            toyota.AddColors("Civic", new List<string> { "Red", "Blue", "White" });
            toyota.AddColorSurcharge("Civic", "Red", 500);
            toyota.AddColors("CRX", new List<string> { "Black", "Silver", "Grey" });
            toyota.AddColorSurcharge("CRX", "Black", 1000);
            toyota.AddColors("NSX", new List<string> { "Yellow", "Green", "Blue" });
            toyota.AddColorSurcharge("NSX", "Yellow", 700);
            toyota.AddColors("S2000", new List<string> { "Red", "Black", "White" });
            toyota.AddColorSurcharge("S2000", "Black", 1500);

            Cars bmw = new Cars("BMW");
            bmw.AddModelsAndPrices("M5", 170000);
            bmw.AddModelsAndPrices("M3", 150000);
            bmw.AddModelsAndPrices("M8", 250000);
            bmw.AddModelsAndPrices("X6M", 175000);
            toyota.AddColors("M5", new List<string> { "Red", "Blue", "White" });
            toyota.AddColorSurcharge("M5", "Red", 500);
            toyota.AddColors("M3", new List<string> { "Black", "Silver", "Grey" });
            toyota.AddColorSurcharge("M3", "Black", 1000);
            toyota.AddColors("M8", new List<string> { "Yellow", "Green", "Blue" });
            toyota.AddColorSurcharge("M8", "Yellow", 700);
            toyota.AddColors("X6M", new List<string> { "Red", "Black", "White" });
            toyota.AddColorSurcharge("X6M", "Black", 1500);

            Cars astonmartin = new Cars("Aston Martin");
            astonmartin.AddModelsAndPrices("Rapid S", 200000);
            astonmartin.AddModelsAndPrices("DBX", 250000);
            astonmartin.AddModelsAndPrices("Vanquish", 300000);
            astonmartin.AddModelsAndPrices("One-77", 2000000);
            toyota.AddColors("Rapid S", new List<string> { "Red", "Blue", "White" });
            toyota.AddColorSurcharge("Rapid S", "Red", 500);
            toyota.AddColors("DBX", new List<string> { "Black", "Silver", "Grey" });
            toyota.AddColorSurcharge("DBX", "Black", 1000);
            toyota.AddColors("Vanquish", new List<string> { "Yellow", "Green", "Blue" });
            toyota.AddColorSurcharge("Vanquish", "Yellow", 700);
            toyota.AddColors("One-77", new List<string> { "Red", "Black", "White" });
            toyota.AddColorSurcharge("One-77", "Black", 1500);

            Cars ferrari = new Cars("Ferrari");
            ferrari.AddModelsAndPrices("F40", 1500000);
            ferrari.AddModelsAndPrices("F12 Berlinetta", 250000);
            ferrari.AddModelsAndPrices("GTC4Lusso", 200000);
            ferrari.AddModelsAndPrices("Purosangue", 260000);
            toyota.AddColors("F40", new List<string> { "Red", "Blue", "White" });
            toyota.AddColorSurcharge("F40", "Red", 500);
            toyota.AddColors("F12 Berlinetta", new List<string> { "Black", "Silver", "Grey" });
            toyota.AddColorSurcharge("F12 Berlinetta", "Black", 1000);
            toyota.AddColors("GTC4Lusso", new List<string> { "Yellow", "Green", "Blue" });
            toyota.AddColorSurcharge("GTC4Lusso", "Yellow", 700);
            toyota.AddColors("Purosangue", new List<string> { "Red", "Black", "White" });
            toyota.AddColorSurcharge("Purosangue", "Black", 1500);

            Cars audi = new Cars("Audi");
            audi.AddModelsAndPrices("RS7", 110000);
            audi.AddModelsAndPrices("S8", 140000);
            audi.AddModelsAndPrices("R8", 200000);
            audi.AddModelsAndPrices("RSQ8", 170000);
            toyota.AddColors("RS7", new List<string> { "Red", "Blue", "White" });
            toyota.AddColorSurcharge("RS7", "Red", 500);
            toyota.AddColors("S8", new List<string> { "Black", "Silver", "Grey" });
            toyota.AddColorSurcharge("S8", "Black", 1000);
            toyota.AddColors("R8", new List<string> { "Yellow", "Green", "Blue" });
            toyota.AddColorSurcharge("R8", "Yellow", 700);
            toyota.AddColors("RSQ8", new List<string> { "Red", "Black", "White" });
            toyota.AddColorSurcharge("RSQ8", "Black", 1500);

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
                Console.WriteLine("Please select what you would like to do: ");
                Console.WriteLine("Enter 1 if you want to list every car shop from the city.");
                Console.WriteLine("Enter 2 if you want to select a car shop and list its cars.");
                Console.WriteLine("Enter 3 if you want to see the cheapest car for sale.");
                Console.WriteLine("Enter 4 if you want to see the most expensive car for sale.");
                Console.WriteLine("Press Enter if you want to exit.");

                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Car shops in the city:");
                        Console.WriteLine(japanShop.Name);
                        Console.WriteLine(luxuryShop.Name);
                        break;

                    case "2":
                        Console.WriteLine("Select a car shop:");
                        Console.WriteLine("1: Japan Car Shop");
                        Console.WriteLine("2: Luxury Car Shop");
                        string shopSelection = Console.ReadLine();

                        Shop selectedShop = null;
                        if (shopSelection == "1")
                        {
                            selectedShop = japanShop;
                        }
                        else if (shopSelection == "2")
                        {
                            selectedShop = luxuryShop;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection. Please try again.");
                            continue;
                        }

                        Console.WriteLine("Cars available:");
                        foreach (var car in selectedShop.GetCars())
                        {
                            car.ListModelsAndPrices();
                        }

                        Console.WriteLine("Select a car model:");
                        string selectedModel = Console.ReadLine();
                        Cars selectedCar = selectedShop.GetCarByModel(selectedModel);

                        if (selectedCar != null)
                        {
                            selectedCar.ListColors(selectedModel);
                            Console.WriteLine("Select a color:");
                            string selectedColor = Console.ReadLine();
                            int basePrice = selectedCar.GetPriceWithColor(selectedModel, selectedColor);
                            if (basePrice != -1)
                            {
                                Console.WriteLine("Would you like to add additional insurance for collision? (yes/no)");
                                string insuranceChoice = Console.ReadLine();
                                bool hasAdditionalInsurance = insuranceChoice.Equals("yes", StringComparison.OrdinalIgnoreCase);
                                Insurance insurance = new Insurance(hasAdditionalInsurance);

                                double finalPrice = insurance.CalculateFinalPrice(basePrice);
                                int monthlyCost = insurance.CalculateMonthlyCost();
                                Console.WriteLine($"The final price for the {selectedModel} in {selectedColor} is {finalPrice} $");
                                Console.WriteLine($"The monthly insurance cost is {monthlyCost} $");

                                Console.WriteLine("Are you satisfied with this purchase? (yes/no)");
                                string satisfactionChoice = Console.ReadLine();

                                if (satisfactionChoice.Equals("yes", StringComparison.OrdinalIgnoreCase))
                                {
                                    Purchase purchase = new Purchase(selectedShop.Name, selectedModel, selectedColor, finalPrice, monthlyCost);
                                    purchases.Add(purchase);
                                    Console.WriteLine("Purchase has been added to your list.");
                                }
                                else
                                {
                                    Console.WriteLine("Purchase has been canceled. Please start again.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid color selection. Please try again.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid car model selection. Please try again.");
                        }
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

            SavePurchasesToFile(purchases);
        }

        static void SavePurchasesToFile(List<Purchase> purchases)
        {
            using (StreamWriter writer = new StreamWriter("purchases.txt"))
            {
                foreach (var purchase in purchases)
                {
                    writer.WriteLine(purchase);
                }
            }
            Console.WriteLine("Purchases have been saved to purchases.txt");
        }
    }
}
