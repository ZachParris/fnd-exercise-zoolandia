//This is a Genus that is taking on 5 species (AilurusFulgens, CanisLupus, OrcinusOrca, javanicus(deer), Ursidaes)

namespace Zoolandia.Genera
{
    public abstract class Scolopax : Animal
    {
        public Scolopax(string name, string size) : base (name, size)
        {
            this.Genus = "Scolopax";
        }
        public string Hunt (string name)
        {
            this.Name = name;
            return Hunt();
        }

        public string Hunt()
        {
            return "The " + this.Name + " is hunting for food!";
        }

         public virtual string Swim()
        {
            return " Glub ";
        }
        public virtual string Growl()
        {
            return "Wow ";
        }
    }
}