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

        public virtual string Crawl()
        {
            return "The " + this.Name + " is getting away!";
        }

        public virtual int Age (int animalAge)
        {
            return 0;
        }

        public virtual double Mass (double animalMass)
        {
            return 0.0;
        }
       
     
    }
}