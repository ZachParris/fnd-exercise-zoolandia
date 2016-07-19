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
        public override string Growl(int numberOfGrowls)
        {
            string animalHunt = base.Growl(9);
            return animalHunt + "Grrr";
        }

        public string Growl(){
            return "BAM";
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
