using System;
// using System.Collections.Generic;
using Zoolandia.Animals;
using Zoolandia.Animals.Species;
using Zoolandia.Animals.Genera;
using Zoolandia.Habitats;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Albus turukhanWolf = new Albus("Turukhan Wolf");
            Lupus canis = new Lupus("Gray Wolf");
            Lycaon easternWolf = new Lycaon("Eastern Wolf");
            Savannah wolfSavannah = new Savannah("Savannah");
            
            wolfSavannah.inhabitants.Add(turukhanWolf);
            wolfSavannah.inhabitants.Add(canis);
            wolfSavannah.inhabitants.Add(easternWolf);

            Console.WriteLine ("Habitat: " + wolfSavannah.Name);

            Americanus blackBear = new Americanus("American Black Bear");
            Arctos grizzlyBear = new Arctos("Grizzly Bear");
            Maritimus polarBear = new Maritimus("Polar Bear");
            Forests bearForest =  new Forests("Forest");

            bearForest.inhabitants.Add(blackBear);
            bearForest.inhabitants.Add(grizzlyBear);
            bearForest.inhabitants.Add(polarBear);

            Console.WriteLine ("Habitat: " + bearForest.Name);

            Rufus bobCat = new Rufus("Bobcat");
            Paradalis ocelot = new Paradalis("Ocelot");
            Margarita sandCat = new Margarita("Sand Cat");
            Caves catCaves = new Caves("Caves");  

            catCaves.inhabitants.Add(bobCat);
            catCaves.inhabitants.Add(ocelot);
            catCaves.inhabitants.Add(sandCat);
            
            Console.WriteLine ("Habitat: " + catCaves.Name); 


            

            

            Console.ReadLine();
        }
    }
}
