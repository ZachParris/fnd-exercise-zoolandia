namespace Zoolandia.Animals.Genera
{
    public class Rufus : Felis, ISocial
    {
        public Rufus (string name) : base(name)
        {
            this.CommonName = "Bobcat";
            this.ScientificName = "Felis Rufus";
        }
        private string solitary()
        {
            return this.Name + " is usually solitary.";
        }
        public void Solo()
        {
            solitary();
        }
    }
}