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
    }
}
