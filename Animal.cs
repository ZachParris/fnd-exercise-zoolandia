using System;

namespace Zoolandia
{
    public abstract class Animal
    {
        public Animal (string name, string size)
        {
            this.Name = name;
            this.Size = size;
        }
        public string Name {get; set;}
        public string Size {get; set;}


        public virtual string Eat(int numberOfFoodz)
        {
            return "Yum ";
        }
        public virtual string Swim(int numberOfLaps)
        {
            return " Glub ";
        }
        public virtual string Growl(int numberOfGrowls)
        {
            return "Wow ";
        }
        public virtual string Sleep(int numberOfNaps)
        {
            return "Zzz ";
        }
    }
}