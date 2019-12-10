using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLibrary
{
    public class CartItem
    {
        public List<Pizza> Pizzas { get; set; }
        public int TotalCost { get; set; }
    }
}
