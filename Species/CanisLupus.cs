using System;

namespace Zoolandia.Species
{
    //Woofs
    public class CanisLupus : Animal
    {
           public CanisLupus(string name, string size) : base(name, size)
        {
            //dont need to do anything here!
        }
        public override string Growl()
        {
            string animalHunt = base.Growl();
            return animalHunt + "Grrr";
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
