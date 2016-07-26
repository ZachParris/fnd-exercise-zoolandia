using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class Exilis : Branta
    {
        public Exilis(string name, string size) : base(name, size)
        {
            //dont need to do anything here!
        }
        public override int Age (int animalAge)
        {
            return 4;
        }
        public override string Crawl (){
            return "Sneaks away";
        }
    }
}