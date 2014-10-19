﻿namespace DecoratorPattern.ConcreteComponent
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        public override double cost()
        {
            return .89;
        }
    }
}
