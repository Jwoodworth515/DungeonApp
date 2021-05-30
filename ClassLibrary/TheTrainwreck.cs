using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Trainwreck : Monster
    {
        //property
        public DateTime HourChangeBack { get; set; }

        //ctor
        public Trainwreck(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            HourChangeBack = DateTime.Now;

            if (HourChangeBack.Hour < 3 || HourChangeBack.Hour > 20)
            {
                hitChance += 10;
                block = +10;
                minDamage += 1;
                maxDamage += 2;
            }//end if
        }//end ctor

        public override string ToString()
        {
            return string.Format("{0}\n{1}",
                base.ToString(),
                HourChangeBack.Hour < 3 || HourChangeBack.Hour > 20 ? "What a hot mess!  She's is raging out of control" : "In the daylight she is a sobbing disaster and might drown you in her tears of embarassment and regret.");
        }//end string

    }//end class
}//end namespace
