using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaLibrary
{
    public class PizzaMenu
    {
        List<Pizza> _pizzaMenu;
        public PizzaMenu(List<Pizza> pizzaMenu)
        {
            _pizzaMenu = pizzaMenu;
            _pizzaMenu.Add(new Pizza { Id = 1, Name = "Hand-Tossed", Size = "small", Category = "Veg", Price = 99 });
            _pizzaMenu.Add(new Pizza { Id = 2, Name = "Hand-Tossed", Size = "Medium", Category = "Veg", Price = 149 });
            _pizzaMenu.Add(new Pizza { Id = 3, Name = "Hand-Tossed", Size = "Large", Category = "Veg", Price = 199 });
            _pizzaMenu.Add(new Pizza { Id = 4, Name = "Pan Pizza", Size = "small", Category = "Veg", Price = 89 });
            _pizzaMenu.Add(new Pizza { Id = 5, Name = "Pan Pizza", Size = "Medium", Category = "Veg", Price = 129 });
            _pizzaMenu.Add(new Pizza { Id = 6, Name = "Pan Pizza", Size = "Large", Category = "Veg", Price = 179 });
            _pizzaMenu.Add(new Pizza { Id = 7, Name = "chicken Hand-Tossed", Size = "small", Category = "Non Veg", Price = 149 });
            _pizzaMenu.Add(new Pizza { Id = 8, Name = "chicken Hand-Tossed", Size = "Medium", Category = "Non Veg", Price = 199 });
            _pizzaMenu.Add(new Pizza { Id = 9, Name = "chicken Hand-Tossed", Size = "Large", Category = "Non Veg", Price = 249 });
            _pizzaMenu.Add(new Pizza { Id = 10, Name = "chicken Pan Pizza", Size = "small", Category = "Non Veg", Price = 99 });
            _pizzaMenu.Add(new Pizza { Id = 11, Name = "chicken Pan Pizza", Size = "Medium", Category = "Non Veg", Price = 149 });
            _pizzaMenu.Add(new Pizza { Id = 12, Name = "chicken Pan Pizza", Size = "Large", Category = "Non Veg", Price = 199 });
        }
       public void Add(Pizza pizza)
        {
            _pizzaMenu.Add(pizza);
        }


        public List<Pizza> GetList()
        {
            
            return _pizzaMenu;
        }
        public Pizza GetItemById(int id)
        {
            return _pizzaMenu.FirstOrDefault(p => p.Id == id);
        }
        

    }
}
