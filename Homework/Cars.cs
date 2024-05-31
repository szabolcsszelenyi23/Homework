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
        private Dictionary<string, List<string>> colors { get; set; }
        private Dictionary<string, Dictionary<string, int>> colorSurcharges { get; set; }

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

        public void AddModelsAndPrices(string model, int price)
        {
            models.Add(model);
            prices.Add(price);
            colors[model] = new List<string>();
            colorSurcharges[model] = new Dictionary<string, int>();
        }

        public void AddColors(string model, List<string> colorOptions)
        {
            if (colors.ContainsKey(model))
            {
                colors[model].AddRange(colorOptions);
            }
        }

        public void AddColorSurcharge(string model, string color, int surcharge)
        {
            if (colorSurcharges.ContainsKey(model))
            {
                colorSurcharges[model][color] = surcharge;
            }
        }

        public void ListModelsAndPrices()
        {
            Console.WriteLine($"Models and prices of the {make} brand:");
            for (int i = 0; i < models.Count; i++)
            {
                Console.WriteLine($"{models[i]}: {prices[i]} $");
            }
        }

        public void ListColors(string model)
        {
            if (colors.ContainsKey(model))
            {
                Console.WriteLine($"Available colors for {model}:");
                foreach (var color in colors[model])
                {
                    int surcharge = colorSurcharges[model].ContainsKey(color) ? colorSurcharges[model][color] : 0;
                    Console.WriteLine($"{color} (Surcharge: {surcharge} $)");
                }
            }
            else
            {
                Console.WriteLine($"No colors available for {model}.");
            }
        }

        public int GetPriceWithColor(string model, string color)
        {
            int index = models.IndexOf(model);
            if (index == -1)
            {
                return -1;
            }
            int basePrice = prices[index];
            int surcharge = colorSurcharges[model].ContainsKey(color) ? colorSurcharges[model][color] : 0;
            return basePrice + surcharge;
        }

        public int CheapestPrice()
        {
            return prices.Min();
        }

        public int MostExpensivePrice()
        {
            return prices.Max();
        }

        public bool HasModel(string model)
        {
            return models.Contains(model);
        }

        public Cars(string make)
        {
            this.make = make;
            models = new List<string>();
            prices = new List<int>();
            colors = new Dictionary<string, List<string>>();
            colorSurcharges = new Dictionary<string, Dictionary<string, int>>();
        }
    }
}
