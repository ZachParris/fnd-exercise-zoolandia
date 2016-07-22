//This is a Genus that is taking on 5 species (AilurusFulgens, CanisLupus, OrcinusOrca, javanicus)

using System;

namespace Zoolandia.Genera
{
    public abstract class Scolopax : Animal
    {
        public Scolopax(string name, string size) : base (name, size){
            this.Genus = "Scolopax";
        }
    }
}