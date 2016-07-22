//This is a Genus that is taking on 5 species (Lotor, vulpes, Canadensis, grylio, mississippiensis)

using System;

namespace Zoolandia.Genera
{
    public abstract class Himantopus : Animal
    {
        public Himantopus(string name, string size) : base (name, size){
            this.Genus = "Himantopus";
        }
    }
}