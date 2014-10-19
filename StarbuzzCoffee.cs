using System;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorators;

namespace DecoratorPattern
{
    public class StarbuzzCoffee
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            beverage = new Mocha(beverage);

            Console.WriteLine(beverage.getDescription() +"$"+ beverage.cost());

            //Beverage beverage2 = new DarkRoast();
            //beverage2 = new Mocha(beverage2);
            //beverage2 = new Mocha(beverage2);
            //beverage2 = new Soy(beverage2);
            //Console.WriteLine(beverage2.getDescription() + "$" + beverage2.cost());

            //Beverage beverage3 = new HouseBlend();
            //beverage3 = new Whip(beverage3);
            //beverage3 = new Whip(beverage3);
            //beverage3 = new Milk(beverage3);

            //Console.WriteLine(beverage3.getDescription() + "$" + beverage3.cost());

            Console.ReadKey();
        }
    }
}
