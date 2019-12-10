using PizzaLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PizzaLibrartTest
{
    public class CartTests
    {
        
        
        [Fact]
        public void Add_pizza_Into_Cart_With_Topping()
        {
            CartItem cartItem = new CartItem();
            cartItem.Pizzas = new List<Pizza>();
            cartItem.TotalCost = 0;
            Cart cart = new Cart(cartItem);
            List<Pizza> pizzas = new List<Pizza>();
            PizzaMenu pizzaMenu = new PizzaMenu(pizzas);
            var menu = pizzaMenu.GetList();
            List<Toppings> toppings = new List<Toppings>();
            ToppingOptions toppingOptions = new ToppingOptions(toppings);
            cart.Add(pizzaMenu.GetItemById(1), toppingOptions.Get_By_Id(1));
            Assert.Equal(1, cartItem.Pizzas[0].Id);
            Assert.Equal(1, cartItem.Pizzas[0].Topping.Id);
        }
        [Fact]
        public void Add_pizza_Into_Cart_Without_Topping()
        {
            CartItem cartItem = new CartItem();
            Cart cart = new Cart(cartItem);
            cartItem.Pizzas = new List<Pizza>();
            cartItem.TotalCost = 0;
            List<Pizza> pizzas = new List<Pizza>();
            PizzaMenu pizzaMenu = new PizzaMenu(pizzas);
            var menu = pizzaMenu.GetList();
            
            cart.Add(pizzaMenu.GetItemById(1), new Toppings());
            Assert.Equal(1, cartItem.Pizzas[0].Id);
        }
        [Fact]
        public void Add_pizza_Into_Cart_Without_Topping_Multiple()
        {
            CartItem cartItem = new CartItem();
            Cart cart = new Cart(cartItem);
            cartItem.Pizzas = new List<Pizza>();
            cartItem.TotalCost = 0;
            List<Pizza> pizzas = new List<Pizza>();
            PizzaMenu pizzaMenu = new PizzaMenu(pizzas);
            var menu = pizzaMenu.GetList();

            cart.Add(pizzaMenu.GetItemById(1), new Toppings());
            cart.Add(pizzaMenu.GetItemById(2), new Toppings());
            cart.Add(pizzaMenu.GetItemById(3), new Toppings());
            Assert.Equal(3, cartItem.Pizzas.Count);
        }
        [Fact]
        public void Add_pizza_Into_Cart_With_Topping_Multiple()
        {
            CartItem cartItem = new CartItem();
            Cart cart = new Cart(cartItem);
            cartItem.Pizzas = new List<Pizza>();
            cartItem.TotalCost = 0;
            List<Pizza> pizzas = new List<Pizza>();
            PizzaMenu pizzaMenu = new PizzaMenu(pizzas);
            var menu = pizzaMenu.GetList();
            List<Toppings> toppings = new List<Toppings>();
            ToppingOptions toppingOptions = new ToppingOptions(toppings);
            cart.Add(pizzaMenu.GetItemById(1), toppingOptions.Get_By_Id(1));
            cart.Add(pizzaMenu.GetItemById(2), toppingOptions.Get_By_Id(2));
            cart.Add(pizzaMenu.GetItemById(3), toppingOptions.Get_By_Id(3));
            Assert.Equal(3, cartItem.Pizzas.Count);
            Assert.Equal(toppingOptions.Get_By_Id(1), cartItem.Pizzas[0].Topping);
        }
        [Fact]
        public void Add_Pizza_Multiple()
        {
            CartItem cartItem = new CartItem();
            Cart cart = new Cart(cartItem);
            cartItem.Pizzas = new List<Pizza>();
            cartItem.TotalCost = 0;
            List<Pizza> pizzas = new List<Pizza>();
            PizzaMenu pizzaMenu = new PizzaMenu(pizzas);
            var menu = pizzaMenu.GetList();
            List<Toppings> toppings = new List<Toppings>();
            ToppingOptions toppingOptions = new ToppingOptions(toppings);
            cart.Add(pizzaMenu.GetItemById(1), toppingOptions.Get_By_Id(1));
            cart.Add(pizzaMenu.GetItemById(2), toppingOptions.Get_By_Id(2));
            cart.Add(pizzaMenu.GetItemById(3), new Toppings());
            Assert.Equal(3, cartItem.Pizzas.Count);
            Assert.Equal(toppingOptions.Get_By_Id(1), cartItem.Pizzas[0].Topping);

        }
    }
}
