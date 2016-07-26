namespace Zoolandia
{
    public abstract class Animal
    {
        public Animal (string name, string size)
        {
            this.Name = name;
            this.Size = size;
        }
        public string Name {get; set;}
        public string Size {get; set;}
        public string Genus {get; set;}
        public string ScientificName {get; set;}
        
        
        public virtual string Eat(int numberOfFoodz)
        {
            return "Yum ";
        }
        public virtual string Sleep(int hoursOfSleep)
        {
            return "Zzz ";
        }
    }
}