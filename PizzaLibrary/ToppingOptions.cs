using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaLibrary
{
    public class ToppingOptions
    {
        List<Toppings> _toppings;
        public ToppingOptions(List<Toppings> toppings)
        {
            _toppings = toppings;
            _toppings.Add(new Toppings { Id = 1, ToppingName = "TOMATO", Price = 10 });
            _toppings.Add(new Toppings { Id = 2, ToppingName = "CHEESE", Price = 20 });
            _toppings.Add(new Toppings { Id = 3, ToppingName = "OLIVE", Price = 30 });
            _toppings.Add(new Toppings { Id = 4, ToppingName = "ONION", Price = 40 });
            _toppings.Add(new Toppings { Id = 5, ToppingName = "MAYO", Price = 50 });
        }
        public List<Toppings> Get()
        {
            
            return _toppings;
        }
        public Toppings Get_By_Id(int id)
        {
            return _toppings.FirstOrDefault(p => p.Id == id);
        }
    }
}
