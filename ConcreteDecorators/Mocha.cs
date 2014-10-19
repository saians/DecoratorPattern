namespace DecoratorPattern.ConcreteDecorators
{
    public class Mocha : CondimentDecorator
    {
        private Beverage meriBeverage;

        public Mocha(Beverage beverage)
        {
            this.meriBeverage = beverage;
        }

        public override string getDescription()
        {
            return meriBeverage.getDescription() + ", Mocha";
        }

        public override double cost()
        {
            return meriBeverage.cost() + .5;
        }
    }
}
