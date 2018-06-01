using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotATrainer
{
    public class Conversion
    {
        public static int GameXPToUserXP(int xp)
        {
            return xp / 256;
        }

        public static int UserXPToGameXP(int xp)
        {
            return xp * 256;
        }
    }
}
