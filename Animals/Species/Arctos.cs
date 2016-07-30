namespace Zoolandia.Animals.Genera
{
    public class Arctos : Ursus
    {
        public Arctos(string name) : base(name)
        {
            this.CommonName = "Black Bear";
            this.ScientificName = "Ursus Arctos";
        }
        public string Solo(){
            return "The " + this.CommonName + " rolls solo";
        }
        public string Roar(){
            return "Roar";
        }
    
    }
}