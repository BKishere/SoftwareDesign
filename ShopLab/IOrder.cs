using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLab
{
    interface IOrder
    {
        //Exercise 3 Step 2: Add a Clone() function to the IOrder interface. The method should return an object of type IOrder
        Order Clone();
    }
}
