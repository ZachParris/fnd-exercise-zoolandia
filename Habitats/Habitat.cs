// using Zoolandia.Animals.Species;
using System.Collections.Generic;
    

namespace Zoolandia.Habitats
{
    public class Habitat : IAnimal
    {
        public Habitat(string name) 
            {
                this.Name = name;
                this.inhabitants = new List<IAnimal>();
            }
            // private string GetScientificName()
            public string Name { get; set; }

        private List<IAnimal> inhabitants {get; set;}
        
        public bool goodForHiking {get; set;}
        public virtual string visibility()
        {
            return "How far can you see?";
        }
    }
}