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

            Weapon fannyPack = new Weapon(1, 10, "Fanny Pack", 12, false);
            Player player = new Player("The Hipster", 50, 15, 40, 40, Hero.TheHipster, fannyPack);

            do
            {

            } while (true);


        }//end LoadRoom()
    }//end class
}//end namespace
