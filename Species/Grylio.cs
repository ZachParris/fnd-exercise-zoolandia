using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class Grylio : Himantopus
    {
        public Grylio(string name, string size) : base(name, size)
        {
            //dont need to do anything here!
        }
        public override int Hops(int numberOfHops){
            return 0;
        }
    }
}