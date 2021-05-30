using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Threading;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "The Music Pit";
            Thread.Sleep(1000);
            Console.WriteLine("\nCan you survive the perils of the Music Pit?\n");
            Thread.Sleep(3000);
            Console.WriteLine("There are many obstacles that stand between you and the coveted Backstage\n");
            Thread.Sleep(3000);
            Console.Write("Will your story tell the legend of a Hero?\n");
            Thread.Sleep(2500);
            Console.WriteLine("or victories of a Villian?\n");
            Thread.Sleep(3000);
            Console.Write("Proceed with CAUTION as you descend into the Madness........\n");
            Thread.Sleep(4000);
            Console.WriteLine();

            int score = 0;

            //TODO - Create a player*****2nd Step*****
            //We need to learn custom classes for this
            //Creating a weapon & creating the player with the weapon included.

            
            
            
            
            
            //           You could create a bunch of extra weapons for the character to choose from, you could also change the race...

            //Create the outer loop - for the room and monster
            bool exit = false;

            do
            {
                //TODO - Create a monster*****3rd Step*****






                //TODO - Load a room*****1st Step*****
                Console.WriteLine(LoadRoom());

                //TODO - Randomly select a monster to fight*****4th Step*****





                //TODO - Show the monster in the room*****5th Step*****

                
                
                
                //Inner loop for menu
                bool reload = false;

                do
                {
                    //Create a menu
                    #region Menu
                    Console.WriteLine("\nPlease Choose an Action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    //Catch the user choice
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    //Clear the console after the user chooses
                    Console.Clear();

                    //Build our menu functionality
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Attack");
                            //Done(7th) - Handle Attack Functionality
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                //monster is dead...you could put some logic here to have the player get a bonus, loot, or something similar due to defeating the monster.
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}!\n", monster.Name);
                                Console.ResetColor();
                                //reload a new room and monster
                                reload = true;
                                //add to the player's score
                                score++;
                            }
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Run Away");
                            //Done(8th) - Handle Run Away Logic
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();
                            reload = true;//load a new monster
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player Info");
                            //Handle Showing Player info
                            Console.WriteLine(player);
                            Console.WriteLine("Monsters defeated: " + score);
                            //Done? - Handle showing player info
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster Info");
                            Console.WriteLine(monster);
                            //Done(6th) - Hnadle showing monster info
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("No one likes a quitter!");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Thou hast chosen an improper action.  Triest thou again!");
                            break;
                    }//end switch
                    #endregion

                    //Check the player's life
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Dude, you died!");
                        Console.WriteLine($"You defeated {score} monsters during your game!");
                        exit = true;
                    }

                } while (!exit && !reload); //end inside do
            } while (!exit); // end outer do
            //This will display the score for the user upon exiting the program.
            Console.WriteLine("You defeated " + score + " monster" + (score == 1 ? "." : "s."));

        }//end Main()

        private static string LoadRoom()
        {
            string[] rooms =
                {
             "A wall that holds a seat with a hole in it is in this chamber. It's a privy! The noisome stench from the hole leads you to believe that the privy sees regular use.", "Stinking smoke wafts up from braziers made of skulls set around the edges of this room. The walls bear scratch marks and lines of soot that form crude pictures and what looks like words in some strange language.", "Neither light nor dark can penetrate the gloom in this chamber. An unnatural shade fills it, and the room's farthest reaches are barely visible. Lining the pillars are skeletons of all shapes and sizes.  It's as if anyone that enters this room, never makes the journey to the other end.  At the far end you can just barely perceive a lump about the size of a human lying on the floor. (It might be a dead body, a pile of rags, or a sleeping monster that can take advantage of the room's darkness.)", "This room makes everyone entering it feel claustrophobic. The walls feel like they are constantly closing in, and ceiling looks menacing.  The energy here amplifies the deafening noise as you gasp for air.", "A chill wind blows against you as you open the door. Beyond it, you see that the floor and ceiling are nothing but iron grates. Above and below the grates the walls extend up and down with no true ceiling or floor within your range of vision. It's as though the chamber is a bridge through the shaft of a great well. Standing on the edge of this shaft, you feel a chill wind pass down it and over your shoulder into the hall beyond.", "entering this room raises your heartbeat to an unnatural level.  The smells are enchanting and the rows of tables host mountains of provisions. At long last, you have found the backstage!  A magical place full of everything that your heart desires.  There is only one thing stopping you from entering the room.....The Fun Police.", "This small chamber resembles nothing that the name suggests. If it is called the green room, why does it lack any shade of green?  It seems to have the remnants of a feast made for an army that has been picked clean.  The pungent smell of dried sweat and shame is almost unbearable.  An open curtain at the end of the room reveals what seems to be extension of the room.  With the lights flickering a shadowy figure approaches.", "There are strange faraway sounds of people talking in this room. The sounds can-not be deciphered. The room is completely empty....except for....", "This room is filled with the most brilliant colors followed by total and complete darkness. Between the flashing of lights and the black are stars. Millions of stars. Stepping into the room one gets the uncanny impression of floating in deep space.", "Stepping into this room is like entering a desert during a high sun. The walls are a faded yellow, and the floor has a sand like pattern. The ceiling is a bright white. Staying in this room for longer than 5 minutes makes you feel parched.", "This room is a raging inferno of fire. It isn't magical, and it will hurt. The magical effect of the room is in keeping the fire contained inside it. Carefully and slowly walking into the room one will realize that there is a safe narrow path inside which will take you to the other exit(s).  There is only one thing standing between you and the promise of safer harbors."
            };
            //Generate a random object
            Random rand = new Random();
            //Generate a random index number using Next()
            int indexNbr = rand.Next(rooms.Length);
            //Create a string for the single room that will be returned
            string room = rooms[indexNbr];
            //Return the room
            return room;
        }//end LoadRoom()
    }//end class
}//end namespace
