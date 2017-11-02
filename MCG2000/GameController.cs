using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG2000
{
    public class GameController
    {

        public NonPlayerCharacter enemy;
        public PlayerCharacter player;
        public NonPlayerCharacter m_NonPlayerCharacter;

        public GameController(NonPlayerCharacter enemy, PlayerCharacter player, NonPlayerCharacter m_NonPlayerCharacter)
        {
            this.enemy = enemy;
            this.player = player;
            this.m_NonPlayerCharacter = m_NonPlayerCharacter;

            enemy = new NonPlayerCharacter();
        }

        ~GameController()
        {

        }
        /// <param name="chooseClass"></param>
        public string ChooseClass(string chooseClass)
        {
            switch (chooseClass)
            {
                case "Warrior":
                    player = new Warrior(50);
                    break;
                case "Thief":
                    player = new Thief(50);
                    break;
                case "Mage":
                    player = new Mage(50);
                    break;
            }
            return "";
        }

        /// 
        /// <param name="characterType"></param>
        public int CreateCharacter(string characterType)
        {

            return 0;
        }

        /// 
        /// <param name="attackType"></param>
        public int NormalAttack(string attackType)
        {

            return 0;
        }

        /// 
        /// <param name="health"></param>
        public int setCurrentHealthPoints(int health)
        {

            return 0;
        }

        /// 
        /// <param name="health"></param>
        public int SetMaxHealth(int health)
        {

            return 0;
        }

        /// 
        /// <param name="attackType"></param>
        public bool SpecialAttack(string attackType)
        {

            return false;
        }

    }//end GameController
}
