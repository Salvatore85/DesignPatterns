using FactoryPattern.Pizzas;
using FactoryPattern.PizzaStores;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var nyStore = new NYPizzaStore();
            var pizza = nyStore.OrderPizza(PizzaType.Pepperoni);
            Console.WriteLine($"Here is your {pizza.Name}");

            var chicagoStore = new ChicagoPizzaStore();
            var pizza1 = chicagoStore.OrderPizza(PizzaType.Pepperoni);
            Console.WriteLine($"Here is your {pizza1.Name}");
        }
    }
}
