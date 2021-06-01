using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MudPeople : Monster
    {
        //ctor
        public MudPeople(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            Name = name;
            Life = life;
            MaxLife = maxLife;
            HitChance = hitChance;
            Block = block;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = description;

        }//end ctor

        public override string ToString()
        {
            return string.Format("{0}\n",
                base.ToString());

        }//end ToString()

    }//end class
}//end namespace
