using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG2000
{
    public class PlayerCharacter : Character
    {
        public string characterName;
        public string normalAttack;
        public string playerClass;
        public SpecialAttack specialAttack;
        public NormalAttack m_NormalAttack;
        public SpecialAttack m_SpecialAttack;

        

        public PlayerCharacter(string characterName, string normalAttack, string playerClass, SpecialAttack specialAttack, NormalAttack m_NormalAttack, SpecialAttack m_SpecialAttack)
        {
            currentHealthPoints = 50;
            this.characterName = characterName;
            this.normalAttack = normalAttack;
            this.playerClass = playerClass;
            this.specialAttack = specialAttack;
            this.m_NormalAttack = m_NormalAttack;
            this.m_SpecialAttack = m_SpecialAttack;
        }

        ~PlayerCharacter()
        {

        }

        /// 
        /// <param name="Damage"></param>
        public int BaseDamage(int Damage)
        {

            return 0;
        }

    }
}
