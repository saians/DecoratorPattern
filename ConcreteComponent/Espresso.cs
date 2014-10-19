namespace DecoratorPattern.ConcreteComponent
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override double cost()
        {
            return 1.99;
        }

        //public int getSize()
        //{
        //    return size;
        //}

        //public int setSize(int s)
        //{
        //    return size = s;
        //}
    }
}
