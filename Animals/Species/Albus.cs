namespace Zoolandia.Animals.Genera
{
    public class Albus : Canis, ITalk
    {
        public Albus (string name) : base(name)
        {
            this.CommonName = "Turukhan wolf";
            this.ScientificName = "Canis lupus albus";
        }
        public string Howl(){
            return "Howwwwwwllll!";
        }
        public string Pack(){
            return this.Name + " is a pack animal";
        }
    }
}