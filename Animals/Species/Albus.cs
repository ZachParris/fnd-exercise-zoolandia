namespace Zoolandia.Animals.Genera

{
    public class Albus : Canis, ITalk
    {
        public Albus (string name) : base(name)
        {
            this.CommonName = "Turukhan wolf";
            this.ScientificName = "Canis lupus albus";
        }
        private void howl(){
        }

        public void MakeSound() 
        {
            howl();
        }

        public string Solo()
        {
            return this.Name + " is a pack animal";
        }
    }
}