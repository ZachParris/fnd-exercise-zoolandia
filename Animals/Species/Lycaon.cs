using Zoolandia.Animals.Genera;

namespace Zoolandia.Animals.Species
{
    public class Lycaon : Lupus, ITalk
    {
        public Lycaon (string name) : base(name)
        {
            this.CommonName = "Eastern Wolf";
            this.ScientificName = "Canis lycaon";
        }
        public string Howl(){
            return "arrroooooooo!!";
        }
    }
}