using System;

namespace Zoolandia.Species
{
    //orcas
    public class OrcinusOrca : Animal
    {
           public OrcinusOrcas(string name) : base(name)
        {
            //dont need to do anything here!
        }
        public override string Swim(int numberOfLaps)
        {
            string animalSwim = base.Eat(3);
            return animalSwim + "glub glub glub";
        }

        public string Swim(){
            return "Shwoosh";
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
