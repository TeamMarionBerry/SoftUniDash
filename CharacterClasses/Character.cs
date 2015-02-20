using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDash.CharacterClasses
{
    public class Character : Unit
    {
        public Character(string name, int x, int y, int health, int currentHealth, int damage, int height, int width, int range)
            : base(x, y, health, currentHealth, damage, height, width, range)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
