//This is a Genus that is taking on 5 species (Odoratus, Scripta, Kempi, Sula, Exilis)

using System;

namespace Zoolandia.Genera
{
    public abstract class Branta : Animal
    {
        public Branta(string name, string size) : base (name, size){
            this.Genus = "Branta";
        }
    }
}