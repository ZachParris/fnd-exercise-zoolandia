using System;

namespace Zoolandia.Species
{
    //bears
    public class Ursidaes : Animal 
    {
           public Ursidaes(string name) : base(name)
        {
            //dont need to do anything here!
        }
        public override string Sleep(int numberOfNaps)
        {
            string animalSleep = base.Sleep(7);
            return animalSleep + "Zzz";
        }

        public string Sleep(){
            return "Snore";
        }

        public string Classifications (string type)
        {
            this.Type = type;
            return Classifications();
        }

        public string Classifications()
        {
            return "This bear is a " + this.Type + " bear.";
        }

    }
}
