using PizzaLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PizzaLibrartTest
{
    public class PizzaMenuTests
    {
        [Fact]
        public void Get_Menu_For_Pizza()
        {
            List<Pizza> pizzas = new List<Pizza>();
            PizzaMenu pizzaMenu = new PizzaMenu(pizzas);
            var menu = pizzaMenu.GetList();
            int expected = 12;
            Assert.Equal(expected,menu.Count);

        }
        [Fact]
        public void Add_Pizza_To_Menu()
        {
            List<Pizza> pizzas = new List<Pizza>();
            PizzaMenu pizzaMenu = new PizzaMenu(pizzas);
            Pizza pizza = new Pizza { Id = 13, Name = "Butter Chicken Pizza", Size = "Medium", Category = "Non Veg", Price = 199 };
            pizzaMenu.Add(pizza);
            var menu = pizzaMenu.GetList();
            int expected = 13;
            Assert.Equal(expected, menu.Count);

        }
        [Fact]
        public void Get_Pizza_By_Valid_Id()
        {
            List<Pizza> pizzas = new List<Pizza>();
            PizzaMenu pizzaMenu = new PizzaMenu(pizzas);
            var menuItem = pizzaMenu.GetItemById(1);
            int expected = 1;
            Assert.Equal(expected, menuItem.Id);

        }
        [Fact]
        public void Get_Pizza_By_Invalid_Id()
        {
            List<Pizza> pizzas = new List<Pizza>();
            PizzaMenu pizzaMenu = new PizzaMenu(pizzas);
            var menuItem = pizzaMenu.GetItemById(123);
            
            Assert.Null(menuItem);

        }
    }
}
