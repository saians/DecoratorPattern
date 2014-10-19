namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";
        public int size;

        public string getDescription()
        {
            return description;
        }

        public abstract double cost();

        public  int getSize()
        {
            return size;
        }

        public int setSize(int sizeE)
        {
           return this.size = sizeE;
        }
    }
}
