using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG2000
{
    public class BackStab : SpecialAttack
    {

        public BackStab()
        {

        }

        public BackStab(int baseDamage) : base(baseDamage)
        {
        }

        ~BackStab()
        {

        }

        /// 
        /// <param name="SuccessRate"></param>
        public bool CalculateSuccessRate(int SuccessRate)
        {

            return false;
        }

    }//end BackStab
}
