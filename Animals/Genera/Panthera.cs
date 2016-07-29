namespace Zoolandia.Animals.Genera
{
    public abstract class Panthera : Animal
    {
        public Panthera(string name) : base (name) {
            this.Genus = "Panthera";
            this.Lifespan = 0;
        }
     
    }
}