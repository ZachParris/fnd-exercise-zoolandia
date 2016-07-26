using Zoolandia.Genera;
namespace Zoolandia.Species
{
    public class AilurusFulgens : Scolopax
    {
        public AilurusFulgens(string name, string size) : base(name, size)
        {
            //dont need to do anything here!
        }
        public override string Eat(int numberOfFoodz)
        {
            string animalEat = base.Eat(3);
            return animalEat + "nom nom nom";
        }

        public string Eat(){
            return "I don't know what I just ate, but it was good";
        }

        public string Welcome (string name)
        {
            this.Name = name;
            return Welcome();
        }

        public string Welcome()
        {
            return "Welcome, " + this.Name;
        }
    }
}