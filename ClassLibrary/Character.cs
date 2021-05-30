using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
        public abstract class Character
        {
            //fields
            private int _life;

            //properties
            public string Name { get; set; }
            public int HitChance { get; set; }
            public int Block { get; set; }
            public int MaxLife { get; set; }
            public int Life
            {
                get { return _life; }
                set
                {
                    if (value <= MaxLife)
                    {
                        _life = value;
                    }
                    else
                    {
                        _life = MaxLife;
                    }
                }
            }//end props

            //methods
            public virtual int Calcblock()
            {
                return Block;
            }//end CalBlock

            public virtual int CalcHitChance()
            {
                return HitChance;
            }//end CalHit

            public virtual int CalcDamage()
            {
                return 0;
            }//End CalDam

        }//end class
}//end namespace
