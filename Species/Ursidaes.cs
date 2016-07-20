using System;

namespace Zoolandia.Species
{
    //bears
    public class Ursidaes : Animal 
    {
           public Ursidaes(string name, string size) : base(name, size)
        {
            //dont need to do anything here!
        }
        public override string Sleep()
        {
            string animalSleep = base.Sleep();
            return animalSleep + "Zzz";
        }

        public string Hunt(){
            return "The " + this.Size + this.Name + " bear is hunting you!";
        }

    }
}
