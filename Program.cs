using System;
using Zoolandia.Animals.Species;
using Zoolandia.Animals.Genera;
using Zoolandia.Habitats;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Instantiating each species in Wolf Genus
            Albus turukhanWolf = new Albus("Turukhan Wolf");
            Lupus canis = new Lupus("Gray Wolf");
            Lycaon easternWolf = new Lycaon("Eastern Wolf");
            //Setting Habitat for wolves
            Savannah wolfSavannah = new Savannah("Savannah");
            
            wolfSavannah.inhabitants.Add(turukhanWolf);
            wolfSavannah.inhabitants.Add(canis);
            wolfSavannah.inhabitants.Add(easternWolf);

            Console.WriteLine ("Habitat: " + wolfSavannah.Name);
            //Display animals in Habitat
            IAnimal[] WolfSavannah = {turukhanWolf, canis, easternWolf};
            wolfSavannah.inhabitants.AddRange(WolfSavannah);
            foreach (var inhabitants in wolfSavannah.inhabitants)
                {
                    Console.WriteLine("\n" + inhabitants);
                }

            //Instantiating each species in Bear Genus
            Americanus blackBear = new Americanus("American Black Bear");
            Arctos grizzlyBear = new Arctos("Grizzly Bear");
            Maritimus polarBear = new Maritimus("Polar Bear");
            //Setting Habitat for bears
            Forests bearForest =  new Forests("Forest");

            bearForest.inhabitants.Add(blackBear);
            bearForest.inhabitants.Add(grizzlyBear);
            bearForest.inhabitants.Add(polarBear);

            Console.WriteLine ("Habitat: " + bearForest.Name);


            //Instantiating each species in Cat Genus
            Rufus bobCat = new Rufus("Bobcat");
            Paradalis ocelot = new Paradalis("Ocelot");
            Margarita sandCat = new Margarita("Sand Cat");
            //Setting Habitat for cats
            Caves catCaves = new Caves("Caves");  

            catCaves.inhabitants.Add(bobCat);
            catCaves.inhabitants.Add(ocelot);
            catCaves.inhabitants.Add(sandCat);

            Console.WriteLine ("Habitat: " + catCaves.Name); 


            Console.ReadLine();
        }
    }
}
