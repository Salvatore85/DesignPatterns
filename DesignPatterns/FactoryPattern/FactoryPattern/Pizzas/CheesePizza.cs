using FactoryPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(IIngredientFactory ingredientFactory)
            :base(ingredientFactory)
        {

        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
            Cheese = IngredientFactory.CreateCheese();
        }
    }
}
