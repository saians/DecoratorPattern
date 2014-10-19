namespace DecoratorPattern.ConcreteComponent
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }
        public override double cost()
        {
            return 2.5;
        }
    }
}
