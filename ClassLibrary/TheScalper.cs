using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public class Scalper : Monster
    {
        //property
        public DateTime HourChangeBack { get; set; }

        //ctor
        public Scalper(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            HourChangeBack = DateTime.Now;

            if (HourChangeBack.Hour < 6 || HourChangeBack.Hour > 18)
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
                HourChangeBack.Hour < 12 || HourChangeBack.Hour > 18 ? "Did this guy buy all of the tickets to the show!\n Look at him walking around snapping his rubberbands like he owns the place." : "He must of got stiffed with a bunch of tickets, he looks pretty marose now.");
        }//end ToString()

    }//end class
}//end namespace