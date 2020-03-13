using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLab
{
    class Order : IOrder
    {
        public Order() { }
        public Order(decimal totalCost, decimal weightInKG)
        {
            TotalCost = totalCost;
            WeightInKG = weightInKG;            
        }
        public decimal TotalCost { get; set; }
        public decimal WeightInKG { get; set; }
            
        //Practice Exercise 3 Step 3 - Implement the Clone() function for the Order class. 
        //The clone created should be a deep clone.
        public Order Clone(){
            var order = new Order{
                TotalCost = TotalCost,
                WeightInKG = WeightInKG,
            };
            return order;
        }
        
    }
}
