namespace Zoolandia.Animals.Genera
{
    public abstract class Varanus : Animal
    {
        public Varanus(string name) : base (name) {
            this.Genus = "Varanus";
            this.Lifespan = 0;
        }
     
    }
}