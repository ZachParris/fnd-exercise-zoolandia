//This is a Genus that is taking on 5 species (Odoratus(turtle), Scripta(slider turtle), Kempi(mouse), Sula(bird), Exilis(rat))
namespace Zoolandia.Animals.Genera
{
    public abstract class Sphaerophoria : Animal
    {
        public Sphaerophoria(string name) : base (name) {
            this.Genus = "Sphaerophoria";
        }
     
    }
}