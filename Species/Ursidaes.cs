using Zoolandia.Genera;

namespace Zoolandia.Species
{
    //bears
    public class Ursidaes : Scolopax 
    {
           public Ursidaes(string name, string size) : base(name, size)
        {
            //dont need to do anything here!
        }
        public override string Sleep(int hoursOfSleep, string nap)
        {
            string animalSleep = base.Sleep(8, "zzz");
            return animalSleep + "Zzz";
        }

        public string Hunt(){
            return "The " + this.Size + this.Name + " bear is hunting you!";
        }

    }
}
