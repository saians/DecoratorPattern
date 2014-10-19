namespace DecoratorPattern.ConcreteComponent
{
    class DarkRoast: Beverage
    {
        public DarkRoast()
        {
            description = "Dark roast coffee ";
        }
        public override double cost()
        {
            return 3;
        }
    }
}
