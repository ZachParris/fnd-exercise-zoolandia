namespace Zoolandia.Animals.Genera
{
    public class Margarita : Felis, IClimb
    {
        public Margarita (string name) : base(name)
        {
            this.CommonName = "Sand Cat";
            this.ScientificName = "Felis Margarita";
        }
        public string Climb(){
            return "The " + this.CommonName + " loves to climb!";
        }
    }
}