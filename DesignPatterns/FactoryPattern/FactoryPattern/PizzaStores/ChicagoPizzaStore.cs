using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Ingredients;
using FactoryPattern.Pizzas;

namespace FactoryPattern.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public ChicagoIngredientFactory _ingredientFactory;
        public ChicagoPizzaStore()
        {

        }

        public override Pizza CreatePizza(PizzaType type)
        {
            throw new NotImplementedException();
        }
    }
}
