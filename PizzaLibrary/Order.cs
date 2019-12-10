using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLibrary
{
    public class Order
    {
        public string Confirm(CartItem cartItem)
        {
            if (cartItem.TotalCost != 0)
            {
                return "Order Successful";
            }
            else
            {
                return "Add items in cart";
            }
        }
        public int GetTotalAmount(CartItem cartItem)
        {
            return cartItem.TotalCost;
        }
    }
}
