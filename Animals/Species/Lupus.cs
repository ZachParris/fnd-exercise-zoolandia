using Zoolandia.Animals.Genera;
//wolf

namespace Zoolandia.Animals.Species
{
    //Woofs
    public class Lupus : Canis
    {
           public Lupus(string name) : base(name)
        {
            this.CommonName = "Gray wolf";
            this.ScientificName = "Canis lupus";
        }
        public override string Eat(int numberOfFoodz)
        {
            string animalEat = base.Eat(3);
            return animalEat + "chomp!";
        }

        public string Eat(){
            return "I don't know what I just ate, but it was good";
        }

        public string Run()
        {
            return " keeps running";
        }


    }
}
