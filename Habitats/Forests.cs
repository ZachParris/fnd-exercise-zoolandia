    namespace Zoolandia.Habitats
{
    public class Forests : Habitat
    {

        public Forests(string name) : base(name)
        {
            this.Name = "Forests";
            this.goodForHiking = true;
        }
        public override string visibility()
        {
            return "So many trees!!";
        }

    }
}