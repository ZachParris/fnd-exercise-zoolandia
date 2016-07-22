﻿using System;
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

            Console.ReadLine();
        }
    }
}
