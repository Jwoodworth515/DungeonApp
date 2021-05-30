using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Weapon
    {
        //fields
        private int _minDamage;

        //properties
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int BonusHitChance { get; set; }
        public bool IsTwoHanded { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }//end props

        //ctors
        public Weapon(int minDamage, int maxDamage, string name, int bonusHitchance, bool isTwoHanded)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            IsTwoHanded = isTwoHanded;
        }//end ctors

        //methods
        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\n" +
                "Bonus Hit: {3}%\t{4}",
                Name, MinDamage, MaxDamage, BonusHitChance,
                IsTwoHanded ? "Two-Handed" : "One-Handed");
        }//end ToString()

    }//end class
}//end namespace
