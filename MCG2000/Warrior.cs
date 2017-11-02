using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG2000
{
    public class Warrior : PlayerCharacter
    {

        public int maxHealthPoints;

        public Warrior(int maxHealthPoints)
        {
            this.maxHealthPoints = 50;
            currentHealthPoints = 50;
            characterName = "Joe";
            playerClass = "Warrior";
            normalAttack = new NormalAttack().ToString();
            specialAttack = new Beserk();

        }

        ~Warrior()
        {

        }

        /// 
        /// <param name="Beserk"></param>
        public bool SpecialAttack(int Beserk)
        {

            return false;
        }

    }//end Warrior
}
