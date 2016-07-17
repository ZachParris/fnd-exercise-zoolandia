using System;

namespace Zoolandia.Species
{
    //Woofs
    public class CanisLupus : Animal
    {
           public CanisLupus(string name) : base(name)
        {
            //dont need to do anything here!
        }
        public override string Hunt(int numberOfHunts)
        {
            string animalHunt = base.Hunt(9);
            return animalHunt + "Grrr";
        }

        public string Hunt(){
            return "Sniff Sniff Sniff";
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
