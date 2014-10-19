namespace DecoratorPattern.ConcreteDecorators
{
    public class Soy : CondimentDecorator
    {
        private Beverage meriBeverage;

        public Soy(Beverage beverage)
        {
            this.meriBeverage = beverage;
        }
        public override string getDescription()
        {
            return meriBeverage.getDescription() + " ,Soy";
        }

        public override double cost()
        {
            return meriBeverage.cost() + .5;
        }
    }
}
