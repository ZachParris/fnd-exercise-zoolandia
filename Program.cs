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
            //************WOLVES!!***************//

            //Instantiating each species in Wolf Genus
            Albus turukhanWolf = new Albus("Turukhan Wolf");
            Lupus canis = new Lupus("Gray Wolf");
            Lycaon easternWolf = new Lycaon("Eastern Wolf");

            //Setting Habitat for wolves
            Savannah wolf_Savannah = new Savannah("Savannah");
            
            //Add each animal to List
            wolf_Savannah.inhabitants.Add(turukhanWolf);
            wolf_Savannah.inhabitants.Add(canis);
            wolf_Savannah.inhabitants.Add(easternWolf);

            //Output Habitat : Name and then it's assigned animals
            Console.WriteLine ("Habitat: " + wolf_Savannah.Name);
            //Add and Output animals in Habitat
            Animal[] WolfSavannah = {turukhanWolf, canis, easternWolf};
            wolf_Savannah.inhabitants.AddRange(WolfSavannah);
            foreach (var animals in WolfSavannah)
                {
                    Console.WriteLine(animals.Name);
                }

            //**********BEARS!!!*************//    

            //Instantiating each species in Bear Genus
            Americanus blackBear = new Americanus("American Black Bear");
            Arctos grizzlyBear = new Arctos("Grizzly Bear");
            Maritimus polarBear = new Maritimus("Polar Bear");

            //Setting Habitat for bears
            Forests bear_Forest =  new Forests("Forest");

            //Add each animal to List
            bear_Forest.inhabitants.Add(blackBear);
            bear_Forest.inhabitants.Add(grizzlyBear);
            bear_Forest.inhabitants.Add(polarBear);
            Console.WriteLine("\r");
            
            //Output Habitat : Name and then it's assigned animals
            Console.WriteLine ("Habitat: " + bear_Forest.Name);
            Animal[] BearForrest = {blackBear, grizzlyBear, polarBear};
            bear_Forest.inhabitants.AddRange(BearForrest);
            foreach (var animals in BearForrest)
                {
                    Console.WriteLine(animals.Name);
                }

            //********BIG CATS!**********//

            //Instantiating each species in Cat Genus
            Rufus bobCat = new Rufus("Bobcat");
            Paradalis ocelot = new Paradalis("Ocelot");
            Margarita sandCat = new Margarita("Sand Cat");

            //Setting Habitat for cats
            Caves cat_Caves = new Caves("Caves");  

            //Add each animal to List
            cat_Caves.inhabitants.Add(bobCat);
            cat_Caves.inhabitants.Add(ocelot);
            cat_Caves.inhabitants.Add(sandCat);
            Console.WriteLine("\r");

            //Output Habitat : Name and then it's assigned animals
            Console.WriteLine ("Habitat: " + cat_Caves.Name); 
            Animal[] CatCaves = {bobCat, ocelot, sandCat};
            cat_Caves.inhabitants.AddRange(CatCaves);
            foreach (var animals in CatCaves)
                {
                    Console.WriteLine(animals.Name);
                }


            Console.ReadLine();
        }
    }
}
