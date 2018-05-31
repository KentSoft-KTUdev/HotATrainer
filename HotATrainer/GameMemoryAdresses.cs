using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotATrainer
{
    public static class GameMemoryAdresses
    {
        private static int PlayerBase = 0x0069CCFC;
        private static int PlayerWood = 0x9C;
        private static int PlayerMercury = 0xA0;
        private static int PlayerStones = 0xA4;
        private static int PlayerSulfur = 0xA8;
        private static int PlayerCrystals = 0xAC;
        private static int PlayerGems = 0xB0;
        private static int PlayerGold = 0xB4;

        public static int GetPlayerGold()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerBase);
            int goldAddress = player + PlayerGold;
            return App.ProcessesMem.ReadInt32((IntPtr)goldAddress);
        }

        public static int GetPlayerWood()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerBase);
            int woodAddress = player + PlayerWood;
            return App.ProcessesMem.ReadInt32((IntPtr)woodAddress);
        }

        public static int GetPlayerMercury()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerBase);
            int mercuryAddress = player + PlayerMercury;
            return App.ProcessesMem.ReadInt32((IntPtr)mercuryAddress);
        }

        public static int GetPlayerStones()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerBase);
            int stonesAddress = player + PlayerStones;
            return App.ProcessesMem.ReadInt32((IntPtr)stonesAddress);
        }

        public static int GetPlayerSulfur()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerBase);
            int sulfurAddress = player + PlayerSulfur;
            return App.ProcessesMem.ReadInt32((IntPtr)sulfurAddress);
        }

        public static int GetPlayerGems()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerBase);
            int gemsAddress = player + PlayerGems;
            return App.ProcessesMem.ReadInt32((IntPtr)gemsAddress);
        }

        public static int GetPlayerCrystals()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerBase);
            int crystalsAddress = player + PlayerCrystals;
            return App.ProcessesMem.ReadInt32((IntPtr)crystalsAddress);
        }
    }
}
