using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;

namespace HotATrainer
{
    public static class GameMemoryAdresses
    {
        private static int PlayerID = 0x0069CCF4; // not sure yet
        private static int PlayerResourcesBase = 0x0069CCFC;
        private static int PlayerWood = 0x9C;
        private static int PlayerMercuryOffset = 0xA0;
        private static int PlayerStonesOffset = 0xA4;
        private static int PlayerSulfurOffset = 0xA8;
        private static int PlayerCrystalsOffset = 0xAC;
        private static int PlayerGemsOffset = 0xB0;
        private static int PlayerGoldOffset = 0xB4;
        private static int PlayerData = 0x653277AC;
        private static int PlayerMovementOffset = 0x19BA0;
        private static int PlayerEXPOffset = 0x19BA4;

        public static int GetPlayerEXP()
        {
            int address = App.ProcessesMem.ReadInt32((IntPtr)PlayerData);
            int realAddress = address + PlayerEXPOffset;
            return Conversion.GameXPToUserXP(App.ProcessesMem.ReadInt32((IntPtr)realAddress));
        }
        public static void SetPlayerEXP(int amount)
        {
            int address = App.ProcessesMem.ReadInt32((IntPtr)PlayerData);
            int realAddress = address + PlayerEXPOffset;
            App.ProcessesMem.WriteInt32((IntPtr)realAddress, Conversion.UserXPToGameXP(amount));
        }
        public static float GetPlayerAvailableMovement()
        {
            int address = App.ProcessesMem.ReadInt32((IntPtr)PlayerData);
            int realAddress = address + PlayerMovementOffset;
            return App.ProcessesMem.ReadFloat((IntPtr)realAddress);
        }
        public static void SetPlayerAvailableMovement(float amount)
        {

            int address = App.ProcessesMem.ReadInt32((IntPtr)PlayerData);
            int realAddress = address + PlayerMovementOffset;
            App.ProcessesMem.WriteFloat((IntPtr)realAddress, amount);
        }
        public static int GetPlayerGold()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int goldAddress = player + PlayerGoldOffset;
            return App.ProcessesMem.ReadInt32((IntPtr)goldAddress);
        }

        public static int GetPlayerWood()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int woodAddress = player + PlayerWood;
            return App.ProcessesMem.ReadInt32((IntPtr)woodAddress);
        }

        public static int GetPlayerMercury()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int mercuryAddress = player + PlayerMercuryOffset;
            return App.ProcessesMem.ReadInt32((IntPtr)mercuryAddress);
        }

        public static int GetPlayerStones()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int stonesAddress = player + PlayerStonesOffset;
            return App.ProcessesMem.ReadInt32((IntPtr)stonesAddress);
        }

        public static int GetPlayerSulfur()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int sulfurAddress = player + PlayerSulfurOffset;
            return App.ProcessesMem.ReadInt32((IntPtr)sulfurAddress);
        }

        public static int GetPlayerGems()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int gemsAddress = player + PlayerGemsOffset;
            return App.ProcessesMem.ReadInt32((IntPtr)gemsAddress);
        }

        public static int GetPlayerCrystals()
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int crystalsAddress = player + PlayerCrystalsOffset;
            return App.ProcessesMem.ReadInt32((IntPtr)crystalsAddress);
        }

        public static void SetPlayerGold(int amount)
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int goldAddress = player + PlayerGoldOffset;
            App.ProcessesMem.WriteInt32((IntPtr)goldAddress, amount);
        }

        public static void SetPlayerWood(int amount)
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int woodAddress = player + PlayerWood;
            App.ProcessesMem.WriteInt32((IntPtr)woodAddress, amount);
        }

        public static void SetPlayerMercury(int amount)
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int mercuryAddress = player + PlayerMercuryOffset;
            App.ProcessesMem.WriteInt32((IntPtr)mercuryAddress, amount);
        }

        public static void SetPlayerStones(int amount)
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int stonesAddress = player + PlayerStonesOffset;
            App.ProcessesMem.WriteInt32((IntPtr)stonesAddress, amount);
        }

        public static void SetPlayerSulfur(int amount)
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int sulfurAddress = player + PlayerSulfurOffset;
            App.ProcessesMem.WriteInt32((IntPtr)sulfurAddress, amount);
        }

        public static void GetPlayerGems(int amount)
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int gemsAddress = player + PlayerGemsOffset;
            App.ProcessesMem.WriteInt32((IntPtr)gemsAddress, amount);
        }

        public static void SetPlayerCrystals(int amount)
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int crystalsAddress = player + PlayerCrystalsOffset;
            App.ProcessesMem.WriteInt32((IntPtr)crystalsAddress, amount);
        }

        public static void SetPlayerGems(int amount)
        {
            int player = App.ProcessesMem.ReadInt32((IntPtr)PlayerResourcesBase);
            int gemsAddress = player + PlayerGemsOffset;
            App.ProcessesMem.WriteInt32((IntPtr)gemsAddress, amount);
        }
    }
}
