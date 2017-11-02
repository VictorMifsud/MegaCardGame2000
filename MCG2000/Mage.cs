using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG2000
{
    public class Mage : PlayerCharacter
    {

        private int maxHealthPoints;

        public Mage(int maxHealthPoints)
        {
            this.maxHealthPoints = 50;
            currentHealthPoints = 50;
            characterName = "Harry";
            playerClass = "Mage";
            normalAttack = new NormalAttack().ToString();
            specialAttack = new Fireball();
        }

        ~Mage()
        {

        }

        /// 
        /// <param name="Fireball"></param>
        public bool SpecialAttack(int Fireball)
        {

            return false;
        }

    }//end Mage
}
