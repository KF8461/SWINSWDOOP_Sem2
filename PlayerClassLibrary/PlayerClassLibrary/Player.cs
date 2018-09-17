using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerClassLibrary
{
    public class Player
    {
        public string name;
        public int actionPoints;
        public int healthPoints;
        public Player(string pName, int pHealth, int pAP)
        {
            name = pName;
            healthPoints = pHealth;
            actionPoints = pAP;
        }
        public bool checkIfDead()
        {
            if (healthPoints < 0)
            {
                return true;
            }
            else return false;
        }
        public bool checkAP(int apCost)
        {
            if (apCost < actionPoints)
            {
                return true;
            }
            else return false;
        }
    }
}

