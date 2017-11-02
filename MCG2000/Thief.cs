using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG2000
{
    public class Thief : PlayerCharacter
    {

        public int maxHealthPoints;

        public Thief(int maxHealthPoints)
        {
            this.maxHealthPoints = 50;
            currentHealthPoints = 50;
            characterName = "Harry";
            playerClass = "Thief";
            normalAttack = new NormalAttack().ToString();
            specialAttack = new Beserk();
        }

        ~Thief()
        {

        }

        /// 
        /// <param name="BackStab"></param>
        public bool SpecialAttack(int BackStab)
        {

            return false;
        }

    }//end Thief
}
