using System.Collections.Generic;
    

namespace Zoolandia.Habitats
{
    public class Habitat 
    {
        public Habitat(string name) 
            {
                this.Name = name;
                this.inhabitants = new List<IAnimal>();
            }
            public string Name {get; set;}


        public List<IAnimal> inhabitants {get; set;}

        public void AddInhabitant(IAnimal inhabitant)
        {

        }
        
        public bool goodForHiking {get; set;}
        public virtual string visibility()
        {
            return "How far can you see?";
        }
    }
}