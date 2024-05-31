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
        private Dictionary<string, List<string>> modelColors { get; set; } // Új tulajdonság a színekhez
        private Dictionary<string, Dictionary<string, int>> colorSurcharges { get; set; } // Új tulajdonság a szín-felárakhoz


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

        public bool HasModel(string model)
        {
            return models.Contains(model);
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

        public void AddColors(string model, List<string> colors)
        {
            if (modelColors.ContainsKey(model))
            {
                modelColors[model].AddRange(colors);
            }
        }

        public void AddColorSurcharge(string model, string color, int surcharge)
        {
            if (colorSurcharges.ContainsKey(model))
            {
                colorSurcharges[model][color] = surcharge;
            }
        }

        public void ListColors(string model)
        {
            if (modelColors.ContainsKey(model))
            {
                Console.WriteLine($"Available colors for {model}: {string.Join(", ", modelColors[model])}");
            }
        }

        public int GetPriceWithColor(string model, string color)
        {
            if (models.Contains(model) && modelColors[model].Contains(color))
            {
                int modelIndex = models.IndexOf(model);
                int basePrice = prices[modelIndex];
                int surcharge = colorSurcharges[model].ContainsKey(color) ? colorSurcharges[model][color] : 0;
                return basePrice + surcharge;
            }
            return -1;
        }

        public Cars(string make)
        {
            this.make = make;
            models = new List<string>();
            prices = new List<int>();
            modelColors = new Dictionary<string, List<string>>(); // Inicializálás a színekhez
            colorSurcharges = new Dictionary<string, Dictionary<string, int>>(); // Inicializálás a felárakhoz
        }
    }
}
