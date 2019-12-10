using PizzaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PzzaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> pizzas = new List<Pizza>();
            PizzaMenu pizzaMenu = new PizzaMenu(pizzas);
            var menu = pizzaMenu.GetList();
            List<Toppings> toppings = new List<Toppings>();
            var toppingOptions = new ToppingOptions(toppings);
            CartItem cartItems = new CartItem();
            cartItems.Pizzas = new List<Pizza>();
            cartItems.TotalCost = 0;
            Cart cart = new Cart(cartItems);
            toppings = toppingOptions.Get();
            foreach (var item in menu)
            {
                Console.WriteLine("{0,-3} {1,-20} {2,-20} {3,-20} {4,-20}", item.Id, item.Name, item.Size, item.Category, item.Price);
            }
            Console.WriteLine("Enter pizza id to add Pizza and -1 to go to cart");

            string pizzaId = "-1";
            do
            {
                pizzaId = Console.ReadLine();
                Toppings topping = new Toppings();

                var selectedPizza = pizzaMenu.GetItemById(Int32.Parse(pizzaId));
                
                
                if (selectedPizza != null)
                {

                    Console.WriteLine("Would you like some toppings(Y/N)");
                    var option = Console.ReadLine();
                    
                    if (option.ToUpper() == "Y")
                    {
                        foreach (var item in toppings)
                        {
                            Console.WriteLine("{0,-3} {1,-20} {2,-20} ", item.Id, item.ToppingName, item.Price);
                        }
                        Console.WriteLine("Enter Number:");
                        option = Console.ReadLine();
                        topping= toppings.FirstOrDefault(t => t.Id == Int32.Parse(option));
                    }
                    cart.Add(selectedPizza,topping);
                    Console.WriteLine("{0,-3} {1,-20} {2,-20} {3,-20} {4,-20} {5,-20}", selectedPizza.Id, selectedPizza.Name, selectedPizza.Size, selectedPizza.Category, selectedPizza.Price, topping.ToppingName);

                }
                else if (pizzaId != "-1")
                {
                    Console.WriteLine("Invalid selection");
                }

            } while (pizzaId != "-1");
            Console.WriteLine("selected Items:");
            Console.WriteLine("{0,-3} {1,-20} {2,-20} {3,-20} {4,-20}", "Id", "Name", "Size", "Category", "Price");
            foreach (var item in cartItems.Pizzas)
            {
                Console.WriteLine("{0,-3} {1,-20} {2,-20} {3,-20} {4,-20}", item.Id, item.Name, item.Size, item.Category, item.Price);
            }
            Console.WriteLine("\n\nTotal Price : " + cartItems.TotalCost);
            Console.WriteLine("Proceed to book(Y/N):");
            var bookingStatus = Console.ReadLine();
            if (bookingStatus.ToUpper() == "Y")
                Console.WriteLine("Order placed");
            else
                Console.WriteLine("Please re initialise the process");
            Console.Read();
            

        }

    }
}
