namespace PizzaLibrary
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public Toppings Topping { get; set; }


    }
}
