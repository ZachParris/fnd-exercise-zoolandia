    namespace Zoolandia.Habitats
{
    public class Savannah : Habitat
    {
        public Savannah(string name): base(name)
        {
            this.Name = "Savannah";
            this.goodForHiking = false;
        }
        public override string visibility()
        {
            return "I can see for miles!";
        }

    }
}