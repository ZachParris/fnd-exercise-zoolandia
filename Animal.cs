using System;

namespace Zoolandia
{
    public class Animal
    {
        public Animal (string name)
        {
            this.Name = name;
        }
        public string Name {get; set;}

        // public Animal (string type)
        // {
        //     this.Type = type;
        // }
        // public string Type {get; set;}

        public virtual string Eat(int numberOfFoodz)
        {
            return "Yum";
        }
        public virtual string Swim(int numberOfLaps)
        {
            return "Glub Glub";
        }
        public virtual string Hunt(int numberOfHunts)
        {
            return "Grr";
        }
        public virtual string Sleep(int numberOfNaps)
        {
            return "Zzz";
        }
    }
}