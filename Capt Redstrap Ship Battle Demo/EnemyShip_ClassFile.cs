using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capt_Redstrap_Ship_Battle_Demo
{
    class EnemyShip_ClassFile
    {
        private int health;
        private int crew;
        private int agility;
        private int attack;

        public int Health
        {
            get { return health; }
            set
            {
                health = value;
            }
        }

        public int Crew
        {
            get { return crew; }
            set
            {
                crew = value;
            }
        }
        public int Agility
        {
            get { return agility; }
            set
            {
                agility = value;
            }
        }

        public int Attack
        {
            get { return attack; }
            set
            {
                attack = value;
            }
        }
    }
}
