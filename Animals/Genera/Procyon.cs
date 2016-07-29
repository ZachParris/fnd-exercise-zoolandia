namespace Zoolandia.Animals.Genera
{
    public abstract class Procyon : Animal
    {
        public Procyon(string name) : base (name) {
            this.Genus = "Procyon";
            this.Lifespan = 0;
        }
     
    }
}