using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients
{
    public interface IIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IPepperoni CreatePepperoni();
        IClams CreateClams();
    }
}
