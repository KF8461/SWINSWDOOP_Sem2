using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsClassLibrary
{
    public class Melee : Weapon
    {
        public Melee(string pName, int pAttackStat) :base(pName, pAttackStat)
        {
            range = 1;
            critChance = 10;
            apCost = 1;
        }

    }
}
