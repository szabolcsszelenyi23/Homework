using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Shop
    {
        private string name;
        private List<Cars> cars { get; set; }

        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void AddCars(Cars car)
        {
            cars.Add(car);
        }

        public void ListCars()
        {
            Console.WriteLine($"Cars available at {name}:");
            foreach (var car in cars)
            {
                Console.WriteLine(car.Make);
            }
        }

        public int CheapestCar()
        {
            int cheapestPrice = int.MaxValue;
            foreach (var car in cars)
            {
                int carCheapestPrice = car.CheapestPrice();
                if (carCheapestPrice < cheapestPrice)
                {
                    cheapestPrice = carCheapestPrice;
                }
            }
            return cheapestPrice;
        }

        public int MostExpensiveCar()
        {
            int mostExpensivePrice = int.MinValue;
            foreach (var car in cars)
            {
                foreach (var price in car.GetPrices())
                {
                    if (price > mostExpensivePrice)
                    {
                        mostExpensivePrice = price;
                    }
                }
            }
            return mostExpensivePrice;
        }

        public List<Cars> GetCars()
        {
            return cars;
        }

        public Cars GetCarByModel(string model)
        {
            foreach (var car in cars)
            {
                if (car.HasModel(model))
                {
                    return car;
                }
            }
            return null;
        }

        public Shop(string name)
        {
            this.name = name;
            cars = new List<Cars>();
        }
    }
}
