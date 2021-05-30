using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Combat
    {
        //This class will not have fields, properties, or any cors as it is just a warehouse to store our combat functionality.

        //DoAttack - player/monster attacks the other
        public static void DoAttack(Character attacker, Character defender)
        {
            //get a randome number from 1-100 as our dice roll
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(500);
            if (diceRoll <= (attacker.CalcHitChance() - defender.Calcblock()))
            {
                //the attacker hit...calcDamage
                int damageDealt = attacker.CalcDamage();

                //assign the damage
                defender.Life -= damageDealt;

                //Write the result to the screen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!",
                    attacker.Name, defender.Name, damageDealt);
                Console.ResetColor();
            }//end if
            else
            {
                //the attacker missed if we are reaching the else statment
                Console.WriteLine($"{attacker.Name} missed!");
            }//end else
        }//end DoAttack

        public static void DoBattle(Player player, Monster monster)
        {
            //Player attacks first
            DoAttack(player, monster);

            //monster gets an attack only if they are still alive
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }//end if
        }//end DoBattle

    }//end class
}//end namespace