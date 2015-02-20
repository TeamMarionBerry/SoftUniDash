using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDash.CharacterClasses
{
    public class Mage : Character
    {
        public Mage(string spell, string name, int x, int y, int health, int currentHealth, int damage, int height, int width, int range)
            : base(name, x, y, health, currentHealth, damage, height, width, range)
        {
            this.Frozen = spell;
        }

        public string Frozen { get; set; }

        public System.Drawing.Brush Color { get; set; }
    }
}
