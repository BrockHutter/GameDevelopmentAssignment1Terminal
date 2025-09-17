using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        //Opening text to present the player's options
        Console.WriteLine("You find yourself awakening in a cave, with no memory of how you got here. \n\nYou see a bright light at the end of the tunnel which appears to be the exit to this cave.\n\nFrom the other direction, you notice an enchanting blue glow and the formation of some crystals.\n");
        Console.WriteLine("Which direction do you walk in?\n\nType ''OUT'' to go in the direction of the cave exit. Type ''CAVE'' to wander deeper into the cave and explore the mysterious glow.\n");

        //Get the player's direction input
        string direction = Console.ReadLine();

        //Direct the player based on their answer
        if (direction == "OUT")
        {
            //Player leaves cave, present new options
            Console.WriteLine("You wander towards the light, and find yourself standing before a massive, open garden. With no clear way out, you decide to look at some of the fascinating plants, some of which you've never seen before.\n\n Two particular plants catch your eye, a large, spiky plant, and a small, beautiful glowing flower.\n");
            Console.WriteLine("Which plant do you inspect? Type ''SPIKY'' to inspect the spiky plant, or type ''GLOWING'' to inspect the glowing flower.");

            //Player directional input and direct based on answer
            string directionGarden = Console.ReadLine();

            if (directionGarden == "SPIKY")
            {
                Console.WriteLine("The spiky plant turned out to be a massive carnivorous plant! Maybe inspecting the more dangerous looking plant wasn't the best idea...\n\nBut, you don't have time to retreat before it swallows you whole. GAME OVER.");
            }

            else if (directionGarden == "GLOWING")
            {
                Console.WriteLine("You inspect the glowing flower, the flower seems to recognize who you are. It blesses you with a powerful ability to heal others.\nYou go off on your adventure and become a world-known healer, aiding warriors and royalty back to health.");
            }
        }

        //Player goes deeper into the cave instead
        else if (direction == "CAVE")
        {
            Console.WriteLine("You go deeper into the cave towards the gentle, mysterious blue glow. You walk past a number of glowing crystals, and stumble upon a network of caves.\n\nTwo signs catch your eye. One pointing to the left reading 'Mole Town', and another pointing to the right reading 'Dwarf Caves'.\n");
            Console.WriteLine("Which direction do you go? Type 'LEFT' to go towards the mole town. Type 'RIGHT' to go towards the dwarf caves.");
            string directionCave = Console.ReadLine();
            if (directionCave == "LEFT")
            {
                Console.WriteLine("You stumble upon an expansive cave complete with huts constructed of wood, stone and metal with architecture unlike anything you've seen before.\n\nOne of the mole people approaches you. Seeing that you are a stranger, they offer you a place to stay for the night, assuming you were lost in the caves. You take up their offer of generosity, and settle in for the night.");
            }
            else if (directionCave == "RIGHT")
            {
                Console.WriteLine("You enter the mines of the dwarves, here you find caves rich with minerals and valuables, and a number of dwarves hard at work.\n\n'Hey, you!' a dwarf calls to you. 'We're a bit behind on schedule, think you could give us a hand? You'll be rewarded for your services!'\n\nAnd thus, you assisted the dwarves with their daily quota. You have earned 50 gold for your hard work!");
            }
        }
        else
        {
            Console.WriteLine($"Your invalid decision {direction} has led to a heart attack due to indecisiveness\n\nGAME OVER");
        }
    }
}