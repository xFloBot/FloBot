using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloBot.MemoryClass
{
    static class AddressUtil
    {
        private static MemoryRW mc;

        public static void setMemoryRW(MemoryRW mc)
        {
            AddressUtil.mc = mc;
        }
        private static int getFinalPointer(int startPointer,int[] offsetArray)
        {
            
            for(int count = 0;count < offsetArray.Length-1;count++)
                startPointer = mc.ReadInteger(startPointer + offsetArray[count], 4);
 
            return startPointer + offsetArray[offsetArray.Length-1];
        }

        #region InfosAboutChar

        private static int HP_MP_Base = 0x00BE7A70;
        private static int[] CharCurrentHPOffset = { HP_MP_Base, 0x2c8 };
        public static int getCharCurrentHP()
        {
            return mc.ReadInteger(
                getFinalPointer(mc.getBaseAdress().ToInt32(), 
                CharCurrentHPOffset));

        }

        private static int[] CharMaxHPOffset = { HP_MP_Base, 0x2c4 };
        public static int getCharMaxHP()
        {
            return mc.ReadInteger(
                getFinalPointer(mc.getBaseAdress().ToInt32(),
                CharMaxHPOffset));

        }

        private static int[] CharNameOffset = { 0x00BE7A74, 0x4, 0x8, 0x0 };
        public static String getCharName()
        {
            return mc.ReadString(
                getFinalPointer(mc.getBaseAdress().ToInt32(), 
                CharNameOffset),16);
        }

        private static int[] CharLevelOffset = { 0x006515CC, 0x30, 0x10 };
        public static int getCharLevel()
        {
            return mc.ReadInteger(
                getFinalPointer(mc.getBaseAdress().ToInt32(),
                CharLevelOffset));
        }

        private static int[] CharCurrentMPOffset = { HP_MP_Base, 0x2d0 };
        public static int getCharCurrentMP()
        {
            return mc.ReadInteger(
                getFinalPointer(mc.getBaseAdress().ToInt32(),
                CharCurrentMPOffset));
        }
        private static int[] CharMaxMPOffset = { HP_MP_Base, 0x2cc };
        public static int getCharMaxMP()
        {
            return mc.ReadInteger(
                getFinalPointer(mc.getBaseAdress().ToInt32(),
                CharMaxMPOffset));
        }

        private static int[] CharExpPercentOffset = { 0x006515CC, 0x44, 0x10 };
        public static Single getCharExpPercent()
        {
            return mc.ReadSingle(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               CharExpPercentOffset));
        }


        private static int[] CharCurrentExpOffset = { 0x006515CC, 0x38, 0x10 };
        public static int getCharCurrentExp()
        {
            return mc.ReadInteger(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               CharCurrentExpOffset));
        }

        private static int[] CharPosXOffset = { 0x68BF48 };
        public static Single getCharPosX()
        {
            return mc.ReadSingle(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               CharPosXOffset));
        }

        private static int[] CharPosYOffset = { 0x68BF4C };
        public static Single getCharPosY()
        {
            return mc.ReadSingle(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               CharPosYOffset));
        }

        private static int[] CharPosZOffset = { 0x68BF50 };
        public static Single getCharPosZ()
        {
            return mc.ReadSingle(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               CharPosZOffset));
        }
        #endregion


        #region InfosAboutTarget
        private static int targetBase = 0x0065160C;
        private static int[] TargetNameOffset = { targetBase, 0xc, 0x10, 0x0 };
        public static String getTargetName()
        {
            return mc.ReadString(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               TargetNameOffset),40);
        }

        private static int[] TargetCurrentHPOffsett = { targetBase, 0x10, 0x10 };
        public static Single getTargetCurrentHP()
        {
            return mc.ReadSingle(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               TargetCurrentHPOffsett));
        }
        private static int[] TargetMaxHPOffsett = { targetBase, 0x50 };
        public static Single getTargetMaxHP()
        {
            return mc.ReadSingle(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               TargetMaxHPOffsett));
        }

        private static int[] TargetLevelOffsett = { targetBase, 0x18, 0x10, 0x0 };
        public static String getTargetLevel()
        {
            return mc.ReadString(
                getFinalPointer(mc.getBaseAdress().ToInt32(),
                TargetLevelOffsett),3);

        }
        #endregion
    }
}
