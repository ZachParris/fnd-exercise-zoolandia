//This is a Genus that is taking on 5 species (Odoratus(turtle), Scripta(turtle), Kempi(mouse), Sula(bird), Exilis(rat))

using System;

namespace Zoolandia.Genera
{
    public abstract class Branta : Animal
    {
        public Branta(string name, string size) : base (name, size){
            this.Genus = "Branta";
        }
           public override string Eat(int numberOfFoodz)
        {
            string animalEat = base.Eat(2);
            return animalEat = "nom nom";
        }
            public string Crawl (string name)
        {
            this.Name = name;
            return Crawl();
        }

        public string Crawl()
        {
            return "The " + this.Name + " is getting away!";
        }

        public virtual double Smell (double animalSmell)
        {
            return animalSmell;
        }

        public virtual int Mass (int animalMass)
        {
            return animalMass;
        }
       
     
    }
}