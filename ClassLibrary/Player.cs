using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Player : Character
    {
        //properties
        public Hero CharacterRace { get; set; }
        public Villain CharacerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public static int Length { get; set; }

        //ctors - FQ

        public Player(string name, int hitChance, int block, int life, int maxLife, Hero characterRace, Weapon equippedWeapon)
        {
            //prop = param;
            MaxLife = maxLife;//MaxLife is listed first because other values depend on this one to set properly.
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
        }//end FQCTOR

        //methods
        public override string ToString()
        {
            return string.Format("-=-= {0} =-=-\n" +
                "Life: {1} of {2}\n" +
                "Hit Chance: {3}%\n" +
                "Weapon: \n{4}\n" +
                "Block: {5}\n" +
                "Decsription: {6}",
                Name, Life, MaxLife, HitChance, EquippedWeapon, Block, CharacterRace);
        }//end ToString()

        //Build 2 method overrides below which are inherited from the Character class
        public override int CalcDamage()
        {
            //Create a random object
            Random rand = new Random();
            //Determine damage
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            //return damage
            return damage;
        }//end CalcDamage

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }//end CalcHitchance

    }//end class
}//end namespace
