using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsClassLibrary
{
    public abstract class Weapon
    {
        public string name;
        public int range;
        public int attackStat;
        public int apCost;
        public int critChance;

        public int ToCritOrNotToCrit()
        {
            Random rnd = new Random();
            int chance = rnd.Next(1, 100);
            if (chance < critChance)
            {
                return this.Crit();
            }
            else
            {
                return this.Attack();
            }

        }
        public virtual int Crit()
        {
            return this.Attack() * 2;
        }
        public int Poke()
        {
            return 1;
        }
        public virtual int Attack()
        {
            return attackStat;
        }
        public Weapon(string pName, int pAttackStat)
        {
            name = pName;
            attackStat = pAttackStat;
        }
        public int ApCost()
        {
            return apCost;
        }
    }
}
