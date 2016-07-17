using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AilurusFulgens redPanda = new AilurusFulgens("Steve");
            redPanda.Name = "Steve";
            string response = redPanda.Eat(5);

            Console.WriteLine(redPanda.Name + " says " + response);

            AilurusFulgens Joe = new AilurusFulgens("Joe");
            Console.WriteLine(Joe.Welcome("Joe"));
            Console.WriteLine(Joe.Name);

            Ursidaes bear = new Ursidaes("Grizzly");
            bear.Name = "Grizzly";
            string activity = bear.Sleep(3);

            Console.WriteLine("The " + bear.Name + " bear naps all day like " + activity);

            OrcinusOrca whale = new OrcinusOrca("Brian");
            whale.Name = "Brian";
            string behavior = whale.Swim(9);

            Console.WriteLine(whale.Name + " the whale is all like " + behavior);

            CanisLupus wolf = new CanisLupus("Timber");
            wolf.Name = "Timber";
            string mission = wolf.Hunt(1);

            Console.WriteLine(wolf.Name + " the wolf always wants to " + mission);

            Console.ReadLine();
        }
    }
}
