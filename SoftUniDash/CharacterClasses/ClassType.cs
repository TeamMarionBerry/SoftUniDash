using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniDash.CharacterClasses
{
    public class ClassType
    {
        public ClassType()
        {
            this.Type = "Mage";
        }

        public string Spell { get; set; }

        public string Type { get; set; }
    }
}
