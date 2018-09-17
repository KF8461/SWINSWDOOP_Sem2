using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsClassLibrary
{
    public class Ranged : Weapon
    {
        public Ranged(string pName, int pRange, int pAttackStat) : base(pName, pAttackStat)
        {
            range = pRange;
            critChance = 5;
            apCost = 2;
        }
        public override int Crit()
        {
            apCost = 1;
            return this.Attack() * 2;
        }
        public override int Attack()
        {
            apCost = 2;
            Random rnd = new Random();
            
            return Convert.ToInt32(Math.Round(Convert.ToDouble(attackStat * (rnd.Next(50, 100) / 100))));
        }
    }
}
