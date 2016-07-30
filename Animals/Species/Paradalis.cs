// using Zoolandia.Genera;

namespace Zoolandia.Animals.Genera
{
    public class Paradalis : Felis, ITalk
    {
        public Paradalis (string name) : base(name)
        {
            this.CommonName = "Ocelot";
            this.ScientificName = "Felis Paradalis";
        }
        public string Growl(){
            return "The " + this.CommonName + " doesn't like you.";
        }
    }
}