using FactoryPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.PizzaStores
{
    public interface IPizzaStore
    {
        Pizza CreatePizza();
    }
}
