//This is a Genus that is taking on 5 species (Lotor(raccoon), vulpes(fox), Canadensis(otter), grylio(frog), mississippiensis(gator))


namespace Zoolandia.Genera
{
    public abstract class Himantopus : Animal
    {
        public Himantopus(string name, string size) : base (name, size){
            this.Genus = "Himantopus";
        }

          public override string Eat(int numberOfFoodz)
        {
            string animalEat = base.Eat(2);
            return animalEat = "nom nom";
        }

        public string Hunt (string name)
        {
            this.Name = name;
            return Hunt();
        }

        public string Hunt()
        {
            return "The " + this.Name + " is hunting you!";
        }

        public virtual double Length (double animalLength)
        {
            return animalLength;
        }

        public virtual int Mass (int animalMass)
        {
            return animalMass;
        }
        public virtual string Creep (string creep)
        {
            return "creeps";
        }
        public virtual string Swim (string swim)
        {
            return "backstrokes";
        }
        public virtual int Hops (int numberOfHops)
        {
            return 0;
        }
         
        }
    }