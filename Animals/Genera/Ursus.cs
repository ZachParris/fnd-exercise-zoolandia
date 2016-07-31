namespace Zoolandia.Animals.Genera
{
    public abstract class Ursus : Animal
    {
        public Ursus(string name) : base (name) 
        { 
            this.Genus = "Ursus";
        }
        public string Hibernation {get; set;}

        public virtual string Hunt()
        {
            return this.CommonName + " is hungry!";
        }

        }
    }