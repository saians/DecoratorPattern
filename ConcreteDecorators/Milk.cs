namespace DecoratorPattern.ConcreteDecorators
{
    public class Milk : CondimentDecorator
    {
        private Beverage meriBeverage;

        public Milk(Beverage beverage)
        {
            this.meriBeverage = beverage;
        }
        public override string getDescription()
        {
            return meriBeverage.getDescription() + " , Milk ";
        }

        public override int getSize()
        {
            throw new System.NotImplementedException();
        }

        public override int setSize(int s)
        {
            throw new System.NotImplementedException();
        }


        public override double cost()
        {
            return meriBeverage.cost() + .5;
        }

    }
}
