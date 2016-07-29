using Zoolandia.Genera;

namespace Zoolandia.Species
{
    public class Vulpes : Himantopus
    {
        public Vulpes(string name, string size) : base(name, size)
        {
            //dont need to do anything here!
        }
        public override string Eat(int numberOfFoodz)
        {
            string animalEat = base.Eat(3);
            return animalEat + "nom nom nom";
        }

        public string Eat(){
            return "I'm sick of Fox food!";
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
         public override double Length(double itsLength){
            return 4.4;
        }
    }
}