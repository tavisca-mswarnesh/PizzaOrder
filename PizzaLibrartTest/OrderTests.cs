using PizzaLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PizzaLibrartTest
{
    public class OrderTests
    {
        [Fact]
        public void Order_With_One_Item()
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
            Order order = new Order();
            string expected = "Order Successful";
            string actual=order.Confirm(cartItem);
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void Order_With_No_Item()
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
            Order order = new Order();
            string expected = "Add items in cart";
            string actual = order.Confirm(cartItem);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Check_Price_Without_topping()
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
            cart.Add(pizzaMenu.GetItemById(1), new Toppings());
            Order order = new Order();
            int expected = 99;
            int actual = order.GetTotalAmount(cartItem);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Check_Price_With_topping()
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
            Order order = new Order();
            int expected = 109;
            int actual = order.GetTotalAmount(cartItem);
            Assert.Equal(expected, actual);
        }
    }
}
