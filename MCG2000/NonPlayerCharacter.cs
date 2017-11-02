using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG2000
{
    public class NonPlayerCharacter : Character
    {

        public string enemyName;
        public string enemyType;
        public string normalAttack;
        public int baseDamage;

        public NonPlayerCharacter(string enemyName, string enemyType, string normalAttack, int baseDamage)
        {
            var vRnd = new Random();
            var vResult = vRnd.Next(0, 2);
            switch (vResult)
            {
                case 0:
                    this.enemyName = "Tony";
                    this.enemyType = "Goblin";
                    this.normalAttack = normalAttack;
                    currentHealthPoints = 120;
                    this.baseDamage = 15;
                    break;
                case 1:
                    this.enemyName = "Lawrence";
                    this.enemyType = "Troll";
                    this.normalAttack = normalAttack;
                    currentHealthPoints = 80;
                    this.baseDamage = 20;
                    break;
                case 2:
                    this.enemyName = "Mary";
                    this.enemyType = "Pixie";
                    this.normalAttack = normalAttack;
                    currentHealthPoints = 75;
                    this.baseDamage = 10;
                    break;
            }
            
           
        }

        ~NonPlayerCharacter()
        {

        }

        /// 
        /// <param name="Damage"></param>
        public int BaseDamage(int Damage)
        {

            return 0;
        }

        /// 
        /// <param name="Damage"></param>
        public int CalculateBaseDamage(int Damage)
        {

            return 0;
        }

        /// 
        /// <param name="Health"></param>
        public int SetCurrentHealthPoints(int Health)
        {

            return 0;
        }

    }
}
