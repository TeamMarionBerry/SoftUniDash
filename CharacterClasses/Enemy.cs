using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDash.CharacterClasses
{
    class Enemy : Unit
    {
        public Enemy(int x, int y, int health, int currentHealth, int damage, int hight, int width, int range, int pointGiven)
            : base(x, y, health, currentHealth, damage, hight, width, range)
        {
            this.PointsGiven = pointGiven;
        }

        public int PointsGiven { get; set; }
    }
}
