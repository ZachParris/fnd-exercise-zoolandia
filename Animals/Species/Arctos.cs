namespace Zoolandia.Animals.Genera
{
    public class Arctos : Ursus
    {
        public Arctos(string name) : base(name)
        {
            this.CommonName = "Grizzly Bear";
            this.ScientificName = "Ursus Arctos";
        }
        public string Solo()
        {
            return "The " + this.CommonName + " rolls solo";
        }
        private string Roar()
        {
            return "Roar";
        }
        public void MakeSound()
        {
            Roar();
        }
    
    }
}