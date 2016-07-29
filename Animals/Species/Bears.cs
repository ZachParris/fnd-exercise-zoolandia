using Zoolandia.Genera;

namespace Zoolandia.Animals.Genera
{
    //bears
    public class Bears : Ursus 
    {
           public Bears (string name) : base(name)
        {
            this.CommonName = "Grizzly";
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
