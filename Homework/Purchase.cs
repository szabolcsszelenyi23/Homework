using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Purchase
    {
        public string ShopName { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }
        public double FinalPrice { get; set; }
        public int MonthlyInsuranceCost { get; set; }

        public Purchase(string shopName, string carModel, string carColor, double finalPrice, int monthlyInsuranceCost)
        {
            ShopName = shopName;
            CarModel = carModel;
            CarColor = carColor;
            FinalPrice = finalPrice;
            MonthlyInsuranceCost = monthlyInsuranceCost;
        }

        public override string ToString()
        {
            return $"Shop: {ShopName}, Car: {CarModel}, Color: {CarColor}, Price: {FinalPrice} $, Monthly Insurance: {MonthlyInsuranceCost} $";
        }
    }
}
