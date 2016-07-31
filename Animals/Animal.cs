namespace Zoolandia.Animals
{
    public abstract class Animal : IAnimal
    {
        public Animal (string name)
        {
            this.Name = name;
        }
        public Animal (int lifespan)
        {
            this.Lifespan = lifespan;
        }
        public Animal (string name, int lifespan)
        {
            this.Name = name;
            this.Lifespan = lifespan;
        }
        
        public string Name {get; set;}
        protected string CommonName {get; set;}
        public string ScientificName {get; set;}
        public double Size {get; set;}
        public string Genus {get; set;}
        protected int Lifespan {get; set;}
        
        
        public virtual string Eat(int numberOfFoodz)
        {
            return "Yum ";
        }
        public virtual string Sleep(int hoursOfSleep)
        {
            return "Zzz ";
        }
        public string GetScientificName()
        {
            return this.ScientificName;
        }
    }
}


