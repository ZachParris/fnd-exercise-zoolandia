using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class Lotor : Himantopus
    {
        public Lotor(string name, string size) : base(name, size)
        {
            //dont need to do anything here!
        }
        public override string Creep (string creep){
            return "creeps around";
        }
    }
}