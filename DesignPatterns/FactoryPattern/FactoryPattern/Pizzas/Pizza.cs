using FactoryPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ICheese Cheese { get; set; }
        public IPepperoni Pepperoni { get; set; }
        public IClams Clams { get; set; }
        public ISauce Sauce { get; set; }

        protected IIngredientFactory IngredientFactory;

        public Pizza(IIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }

        public void Bake()
        {
            Console.WriteLine("Baking the pizza, please wait.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza in slices");
        }

        public void Box()
        {
            Console.WriteLine("Putting pizza in box.");
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public abstract void Prepare();
    }
}
