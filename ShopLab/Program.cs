using System;

namespace ShopLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order(10, 20);  
            //Check that your Clone() function works correctly by modifying Program.cs to 
            //clone an input IOrder object instead of just saving the reference.  
            Order cloneOrder = myOrder.Clone();

            Console.WriteLine("Initial Object Total Cost: "+myOrder.TotalCost);
            Console.WriteLine("Initial Object WeightInKg: "+myOrder.WeightInKG);
            Console.WriteLine("Cloned Object Total Cost: "+cloneOrder.TotalCost);
            Console.WriteLine("Cloned Object WeightInKg: "+cloneOrder.WeightInKG);


        }
    }
}
