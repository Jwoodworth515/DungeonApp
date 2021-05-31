using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Threading;

namespace Dungeon
{
    class MusicPit
    {
        static void Main(string[] args)
        {
            Console.Title = "The Music Pit";
            Thread.Sleep(1000);
            Console.WriteLine("\nCan you survive the perils of\n");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
▄▄▄█████▓ ██░ ██ ▓█████     ███▄ ▄███▓ █    ██   ██████  ██▓ ▄████▄      ██▓███   ██▓▄▄▄█████▓
▓  ██▒ ▓▒▓██░ ██▒▓█   ▀    ▓██▒▀█▀ ██▒ ██  ▓██▒▒██    ▒ ▓██▒▒██▀ ▀█     ▓██░  ██▒▓██▒▓  ██▒ ▓▒
▒ ▓██░ ▒░▒██▀▀██░▒███      ▓██    ▓██░▓██  ▒██░░ ▓██▄   ▒██▒▒▓█    ▄    ▓██░ ██▓▒▒██▒▒ ▓██░ ▒░
░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄    ▒██    ▒██ ▓▓█  ░██░  ▒   ██▒░██░▒▓▓▄ ▄██▒   ▒██▄█▓▒ ▒░██░░ ▓██▓ ░ 
  ▒██▒ ░ ░▓█▒░██▓░▒████▒   ▒██▒   ░██▒▒▒█████▓ ▒██████▒▒░██░▒ ▓███▀ ░   ▒██▒ ░  ░░██░  ▒██▒ ░ 
  ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░   ░ ▒░   ░  ░░▒▓▒ ▒ ▒ ▒ ▒▓▒ ▒ ░░▓  ░ ░▒ ▒  ░   ▒▓▒░ ░  ░░▓    ▒ ░░   
    ░     ▒ ░▒░ ░ ░ ░  ░   ░  ░      ░░░▒░ ░ ░ ░ ░▒  ░ ░ ▒ ░  ░  ▒      ░▒ ░      ▒ ░    ░    
  ░       ░  ░░ ░   ░      ░      ░    ░░░ ░ ░ ░  ░  ░   ▒ ░░           ░░        ▒ ░  ░      
          ░  ░  ░   ░  ░          ░      ░           ░   ░  ░ ░                   ░           
                                                            ░                                 
");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(@"                         
                           {    }
                           K,   }
                          /  ~Y`
                     ,   /   /
                    {_'-K.__/
                      `/-.__L._
                      /  ' /`\_}
                     /  ' /
             ____   /  ' /
      ,-'~~~~    ~~/  ' /_
    ,'             ``~~~  ',
   (                        Y
  {                         I
 {      -                    `,
 |       ',                   )
 |        |   ,..__      __. Y
 |    .,_./  Y ' / ^Y   J   )|
 \           |' /   |   |   ||
  \          L_/    . _ (_,.'(
   \,   ,      ^^""' / |      )
     \_  \          /,L]     /
       '-_~-,       ` `   ./`
          `'{_            )
              ^^\..___,.--`");

            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("Press any key to enter if you dare");
            Console.ReadKey(true);
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("There are many obstacles that stand between you and the coveted Backstage\n");
            Thread.Sleep(3000);
            Console.Write("Will your story tell the legend of a Hero?\n");
            Thread.Sleep(2500);
            Console.WriteLine("or that of a Villain?\n");
            Thread.Sleep(3000);
            Console.Write("Tread carefully as you descend into the Madness........\n");
            Thread.Sleep(4000);
            Console.WriteLine();

            int score = 0;


            #region MyRegion
            bool repeatQuestion = false;
            do
            {
            Thread.Sleep(1000);
            Console.WriteLine("Choose your path:\n" +
                "H) Hero\n" +
                "V) Villain\n");
            ConsoleKey userChoice = Console.ReadKey(true).Key;
            switch (userChoice)
            {
                case ConsoleKey.H:
                    Console.WriteLine("Your friends will speak of this night as if it were a myth./n");


                        //if (true)
                        //{
                        //Random rand1 = new Random();
                            //int randomNbr1 = rand1.Next(Player.Length);
                            //Player player = Player[randomNbr1];
                        //}
                        break;
                case ConsoleKey.V:
                    Console.WriteLine("You have chosen a dark path.../n");
                        //if (true)
                        //{
                        // Monster[] monsters = { t1, s1, };
                        //Random rand2 = new Random();
                        //int randomNbr2 = rand2.Next(Monster.Length);
                        //Monster monster = monster[randomNbr2];
                        //}
                        break;
                default:
                    Console.WriteLine("There are only two paths, choose your destiny!");
                    break;
            }
            } while (repeatQuestion);
            Thread.Sleep(1000);
            #endregion
            Console.Clear();

            Weapon fannyPack = new Weapon(1, 10, "Fanny Pack", 12, false);
            Player player = new Player("The Hipster", 50, 15, 40, 40, Hero.TheHipster, fannyPack);

            bool exit1 = false;

            do
            {
                Console.WriteLine(GetRoom());
                Thread.Sleep(2000);

                //Heroes
                

                //Villains
                Trainwreck t1 = new Trainwreck("The Trainwreck", 10, 10, 35, 25, 1, 14, "There's an intoxicated person here, don't look her in the eyes!");
                Scalper s1 = new Scalper("The Scalper", 20, 20, 35, 25, 1, 14, "This guy doesn't know when to quit, I already have my tickets!");
                Heckler h1 = new Heckler("The Heckler", 20, 20, 35, 25, 1, 14, "His sharp tongue is powered by his dim wit.  His words can cut right through you!");


                Monster[] monsters = { t1, s1, h1 };

                Random rand = new Random();
                int randomNbr = rand.Next(monsters.Length);
                Monster monster = monsters[randomNbr];

                Console.WriteLine("\nIn this room: " + monster.Name);

                bool reload = false;

                do
                {
                    #region Menu
                    Console.WriteLine("\nPlease Choose an Action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    ConsoleKey userChoice1 = Console.ReadKey(true).Key;

                    Console.Clear();

                    switch (userChoice1)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Attack");
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}!\n", monster.Name);
                                Console.ResetColor();

                                reload = true;

                                score++;
                            }
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Run Away");

                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();
                            reload = true;
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player Info");

                            Console.WriteLine(player);
                            Console.WriteLine("Monsters defeated: " + score);

                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster Info");
                            Console.WriteLine(monster);

                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("To get backstage, you must perservere!");
                            exit1 = true;
                            break;
                        default:
                            Console.WriteLine("ah ah ah, you didn't say the magic word.");
                            break;
                    }//end switch
                    #endregion

                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Failure!  Now you'll never get backstage!");
                        Console.WriteLine($"You defeated {score} monsters during your game!");
                        exit1 = true;
                    }

                } while (!exit1 && !reload); //end inside do
            } while (!exit1); // end outer do

            Console.WriteLine("You defeated " + score + " monster" + (score == 1 ? "." : "s."));

        }//end Main()

        private static string GetRoom()
        {
            string[] rooms =
                {
                 "A wall that holds a seat with a hole in it is in this chamber. It's a privy! The noisome stench from the hole leads you to believe that the privy sees regular use.", "Stinking smoke wafts up from braziers made of skulls set around the edges of this room. The walls bear scratch marks and lines of soot that form crude pictures and what looks like words in some strange language.", "Neither light nor dark can penetrate the gloom in this chamber. An unnatural shade fills it, and the room's farthest reaches are barely visible. Lining the pillars are skeletons of all shapes and sizes.  It's as if anyone that enters this room, never makes the journey to the other end.  At the far end you can just barely perceive a lump about the size of a human lying on the floor. (It might be a dead body, a pile of rags, or a sleeping monster that can take advantage of the room's darkness.)", "This room makes everyone entering it feel claustrophobic. The walls feel like they are constantly closing in, and ceiling looks menacing.  The energy here amplifies the deafening noise as you gasp for air.", "A chill wind blows against you as you open the door. Beyond it, you see that the floor and ceiling are nothing but iron grates. Above and below the grates the walls extend up and down with no true ceiling or floor within your range of vision. It's as though the chamber is a bridge through the shaft of a great well. Standing on the edge of this shaft, you feel a chill wind pass down it and over your shoulder into the hall beyond.", "entering this room raises your heartbeat to an unnatural level.  The smells are enchanting and the rows of tables host mountains of provisions. At long last, you have found the backstage!  A magical place full of everything that your heart desires.  There is only one thing stopping you from entering the room.....The Fun Police.", "This small chamber resembles nothing that the name suggests. If it is called the green room, why does it lack any shade of green?  It seems to have the remnants of a feast made for an army that has been picked clean.  The pungent smell of dried sweat and shame is almost unbearable.  An open curtain at the end of the room reveals what seems to be extension of the room.  With the lights flickering a shadowy figure approaches.", "There are strange faraway sounds of people talking in this room. The sounds can-not be deciphered. The room is completely empty....except for....", "This room is filled with the most brilliant colors followed by total and complete darkness. Between the flashing of lights and the black are stars. Millions of stars. Stepping into the room one gets the uncanny impression of floating in deep space.", "Stepping into this room is like entering a desert during a high sun. The walls are a faded yellow, and the floor has a sand like pattern. The ceiling is a bright white. Staying in this room for longer than 5 minutes makes you feel parched.", "This room is a raging inferno of fire. It isn't magical, and it will hurt. The magical effect of the room is in keeping the fire contained inside it. Carefully and slowly walking into the room one will realize that there is a safe narrow path inside which will take you to the other exit(s).  There is only one thing standing between you and the promise of safer harbors."
            };

            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;
        }//end GetRoom()

    }//end class
}//end namespace

