using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLibrary
{
    public class Cart
    {
        CartItem _cartItems;
        public Cart(CartItem cartItems)
        {
            _cartItems = cartItems;
        }
        public void Add(Pizza pizza,Toppings topping)
        {
            
            pizza.Topping = topping;
            _cartItems.Pizzas.Add(pizza);
            _cartItems.TotalCost = _cartItems.TotalCost + pizza.Price + topping.Price;
            

        }
    }
}
