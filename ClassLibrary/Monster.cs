using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Monster : Character
    {
        //fields
        private int _minDamage;

        //props
        public int MaxDamage { get; set; }
        public string Description { get; set; }
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
                }//end else
            }//end set
        }//end MinDamage

        //ctors - default and FQ
        public Monster() { }

        public Monster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
        {
            //Set maxlife and maxdamage
            MaxLife = maxLife;
            MaxDamage = maxDamage;
            Name = name;
            Life = life;
            HitChance = hitChance;
            Block = block;
            MinDamage = minDamage;
            Description = description;
        }//8 total

        //methods - ToString, CalcDamage
        public override string ToString()
        {
            return string.Format("\n****** MONSTER ******\n" +
                "{0}\n" +
                "Life: {1} of {2}\nDamage: {3} to {4}\nBlock: {5}\nDescription:\n{6}\n",
                Name, Life, MaxLife, MinDamage, MaxDamage, Block, Description);
        }//end ToString()

        //We will override CalcDamage to use min and max damage properties.
        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);//We add 1 here to account for the exclusive upper bound in the .Next()
            //This is a refactored version of what we did in Characters.************
        }

    }//end class
}//end namespace