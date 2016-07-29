// using Zoolandia;s
    

namespace Zoolandia.Habitats
{
    
} public class Habitat 
{
     public Habitat(string name) 
        {
            this.Name = name;
        }
        public string Name { get; set; }

    // Instantiated a new list, which will contain animals.
    // You will add animals at run time (i.e. in `static void Main()
    // `)
    public List<Animal> inhabitants = new List<Animal>();
    // public string public_name { get; }
}