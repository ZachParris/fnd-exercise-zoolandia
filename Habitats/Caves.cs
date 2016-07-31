    namespace Zoolandia.Habitats
{
    public class Caves : Habitat
    {
        public Caves(string name): base(name)
        {
            this.Name = "Caves";
            this.goodForHiking = false;
        }
        public override string visibility()
        {
            return "Well sorta...";
        }
    }
}