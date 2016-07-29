namespace Zoolandia.Animals.Genera
{
    public abstract class Ursus : Animal
    {
        public Ursus(string name) : base (name) {
            this.Genus = "Ursus";
            this.Lifespan = 0;
        }
     
    }
}