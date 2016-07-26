using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class Canadensia : Himantopus
    {
        public Canadensia(string name, string size) : base(name, size)
        {
            //dont need to do anything here!
        }
        public override int Mass (int bodyMass){
            return 0;
        }
        public string Eat(){
            return "I don't know what I just ate, but it was good";
        }
        public override string Swim(string swim){
            return "this.name the otter does the backstroke"
        }

    }
}
