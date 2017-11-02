using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG2000
{
    public class Fireball : SpecialAttack
    {

        public Fireball()
        {

        }

        public Fireball(int baseDamage) : base(baseDamage)
        {
        }

        ~Fireball()
        {

        }

        /// 
        /// <param name="SuccessRate"></param>
        public bool CalculateSuccessRate(int SuccessRate)
        {

            return false;
        }

    }//end Fireball
}