using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients
{
    public class ChicagoIngredientFactory : IIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
    }
}
