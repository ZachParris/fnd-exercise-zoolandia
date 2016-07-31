namespace Zoolandia.Animals.Genera
{
    public abstract class Canis : Animal
    {
        public Canis(string name) : base (name) 
        { 
            this.Genus = "Canis";
        }
        public string Travel {get; set;}

        public virtual string Communication() 
        {
            return "The pack is talking to eachother!";
        }


        }
    }