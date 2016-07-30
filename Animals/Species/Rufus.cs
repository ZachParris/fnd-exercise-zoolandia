namespace Zoolandia.Animals.Genera
{
    public class Rufus : Felis, ISocial
    {
        public Rufus (string name) : base(name)
        {
            this.CommonName = "American Black Bear";
            this.ScientificName = "Ursus americanus";
        }
        public string Solo(){
            return this.Name + " is usually solitary.";
        }
    }
}