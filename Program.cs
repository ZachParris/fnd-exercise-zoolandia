using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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
            string activity = bear.Sleep(3);

            Console.WriteLine("The " + bear.Size + bear.Name + " bear takes a nap " + activity);

            OrcinusOrca whale = new OrcinusOrca("Brian", "huge");
            whale.Name = "Brian";
            whale.Size = "huge";
            string behavior = whale.Swim(9);


            Console.WriteLine(whale.Name + " the " + whale.Size + " whale is all like " + behavior);

            CanisLupus wolf = new CanisLupus("Timber", "giant");
            wolf.Name = "Timber";
            wolf.Size = "giant";
            string noise = wolf.Growl(1);
            

            Console.WriteLine(wolf.Name + " the " + wolf.Size + " wolf be like " + noise);

            Console.ReadLine();
        }
    }
}
