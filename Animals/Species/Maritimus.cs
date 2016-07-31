// using Zoolandia.Genera;

namespace Zoolandia.Animals.Genera
{
    //bears
    public class Maritimus : Ursus, IClimb 
    {
           public Maritimus (string name) : base(name)
        {
            this.CommonName = "Polar";
            this.ScientificName = "Ursus Maritimus";
        }
        public override string Sleep(int hoursOfSleep)
        {
            string animalSleep = base.Sleep(8);
            return animalSleep + "Zzz";
        }

        public string Climb(){
            return "Nothing to climb!";
        }

    }
}
