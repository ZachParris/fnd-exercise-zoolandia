using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AilurusFulgens redPanda = new AilurusFulgens("Steve", "Little");
            redPanda.Name = "Steve";
            string response = redPanda.Eat(5);

            Console.WriteLine(redPanda.Name + " says " + response);

            AilurusFulgens Joe = new AilurusFulgens("Joe", "big");
            Console.WriteLine(Joe.Welcome("Joe"));
            Console.WriteLine(Joe.Name);

            Ursidaes bear = new Ursidaes("Grizzly", "Massive");
            bear.Name = "Grizzly";
            bear.Size = "Massive ";
            string activity = bear.Sleep();

            Console.WriteLine(bear.Hunt());
            Console.WriteLine(bear.Name);

            OrcinusOrca whale = new OrcinusOrca("Brian", "huge");
            whale.Name = "Willy";
            whale.Size = "huge";
            string behavior = whale.Swim();


            Console.WriteLine(whale.Name + " the " + whale.Size + " whale is all like " + behavior);
            Console.WriteLine(whale.Jump());
            Console.WriteLine(whale.Name);

            CanisLupus wolf = new CanisLupus("Timber", "giant");
            wolf.Name = "Timber";
            wolf.Size = "giant";
            string noise = wolf.Growl();
            

            Console.WriteLine(wolf.Name + " the " + wolf.Size + " wolf be like " + noise);
            Console.WriteLine(wolf.Name);

            Console.ReadLine();
        }
    }
}
