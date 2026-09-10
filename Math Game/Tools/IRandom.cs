using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game.Tools;

internal interface IRandom
{
    public int Next(int maxValue);
}
