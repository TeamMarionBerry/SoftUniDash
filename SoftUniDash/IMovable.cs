using SoftUniDash.CharacterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniDash
{
    public interface IMovable
    {
        int[] Move(Moving movingUnit, int unitX, int unitY);
    }
}
