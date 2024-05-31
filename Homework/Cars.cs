using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Cars
    {
        private string make;
        private List<string> models { get; set; }
        private List<int> prices { get; set; }

        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }

        public void AddModelsAndPrices(string modell, int price)
        {
            models.Add(modell);
            prices.Add(price);
        }

        public void ListModelsAndPrices()
        {
            Console.WriteLine($"Models and prices of the {make} Brand:");
            for (int i = 0; i < models.Count; i++)
            {
                Console.WriteLine($"{models[i]} - {prices[i]} $");
            }
        }

        public int CheapestPrice()
        {
            if (prices.Count == 0)
            {
                throw new InvalidOperationException("No prices available to determine the cheapest price.");
            }

            int cheapest = prices[0];
            for (int i = 1; i < prices.Count; i++)
            {
                if (prices[i] < cheapest)
                {
                    cheapest = prices[i];
                }
            }
            return cheapest;
        }

        public List<int> GetPrices()
        {
            return prices;
        }

        public int MostExpensiveCar()
        {
            if (prices.Count == 0)
            {
                throw new InvalidOperationException("No prices available to determine the highes price.");
            }

            int highes = prices[0];
            for (int i = 1; i < prices.Count; i++)
            {
                if (prices[i] > highes)
                {
                    highes = prices[i];
                }
            }

            return highes;
        }

        public string SelectModel(string model)
        {
            if(model == null)
            {
                Console.WriteLine("Invalid model name.");
                throw new InvalidOperationException("Invalid model name.");
            }

            for (int i = 0; i < models.Count; i++)
            {
                if (model.ToLower() == models[i].ToLower()){
                    Console.WriteLine("You selected the {0} - {1}", models[i], prices[i]);
                }
            }
            return model;
        }

        public Cars(string make)
        {
            this.make = make;
            models = new List<string>();
            prices = new List<int>();
        }
    }
}
