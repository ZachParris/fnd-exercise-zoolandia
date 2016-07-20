using System;

namespace Zoolandia.Species
{
    //orcas
    public class OrcinusOrca : Animal
    {
           public OrcinusOrca(string name, string size) : base(name, size)
        {
            //dont need to do anything here!
        }
        public override string Swim()
        {
            string animalSwim = base.Swim();
            return animalSwim + "glub glub";
        }
    
        public string Jump()
        {
           return "Free " + this.Name + " LEAPS over the wall to freedom as the boy cheers"; 
        }

      
    }
}
