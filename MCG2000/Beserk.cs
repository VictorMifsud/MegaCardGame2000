using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG2000
{
    public class Beserk : SpecialAttack
    {

        public Beserk()
        {

        }

        public Beserk(int baseDamage) : base(baseDamage)
        {
        }

        ~Beserk()
        {

        }

        /// 
        /// <param name="SuccessRate"></param>
        public bool CalculateSuccessRate(int SuccessRate)
        {

            return false;
        }

    }//end Beserk
}
