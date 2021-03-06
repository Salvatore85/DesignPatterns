﻿using System;
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
            _ingredientFactory = new ChicagoIngredientFactory();
        }

        public override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza;

            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza(_ingredientFactory);
                    pizza.SetName("Chicago Style Cheese Pizza.");
                    break;
                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza(_ingredientFactory);
                    pizza.SetName("Chicago Style Pepperoni Pizza.");
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza(_ingredientFactory);
                    pizza.SetName("Chicago Style Clam Pizza.");
                    break;
                default:
                    throw new InvalidOperationException("Unkown pizza type.");
            }

            return pizza;
        }
    }
}
