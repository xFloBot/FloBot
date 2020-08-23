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
            {
                startPointer = mc.ReadInteger(startPointer + offsetArray[count], 4);
            }
 
            return startPointer + offsetArray[offsetArray.Length-1];
        }

        #region InfosAboutChar  

        private static int Player_Base = 0x007BA63C;
        private static int[] CharCurrentHPOffset = { Player_Base, 0x60,0x10 };
        public static int getCharCurrentHP()
        {
            return mc.ReadInteger(
                getFinalPointer(mc.getBaseAdress().ToInt32(), 
                CharCurrentHPOffset));

        }

        private static int[] CharMaxHPOffset = { Player_Base, 0x94 };
        public static int getCharMaxHP()
        {
            return mc.ReadInteger(
                getFinalPointer(mc.getBaseAdress().ToInt32(),
                CharMaxHPOffset));

        }

        private static int[] CharCurrentMPOffset = { Player_Base, 0x64, 0x10 };
        public static int getCharCurrentMP()
        {
            return mc.ReadInteger(
                getFinalPointer(mc.getBaseAdress().ToInt32(),
                CharCurrentMPOffset));
        }
        private static int[] CharMaxMPOffset = { Player_Base, 0x98};
        public static int getCharMaxMP()
        {
            return mc.ReadInteger(
                getFinalPointer(mc.getBaseAdress().ToInt32(),
                CharMaxMPOffset));
        }

        private static int[] CharNameOffset = { Player_Base, 0x8, 0x10, 0x0 };
        public static String getCharName()
        {
            return mc.ReadString(
                getFinalPointer(mc.getBaseAdress().ToInt32(), 
                CharNameOffset),16);
        }

        private static int[] CharLevelOffset = { Player_Base, 0x30, 0x10 };
        public static int getCharLevel()
        {
            return mc.ReadInteger(
                getFinalPointer(mc.getBaseAdress().ToInt32(),
                CharLevelOffset));
        }

       

        private static int[] CharExpPercentOffset = { Player_Base, 0x44, 0x10 };
        public static Single getCharExpPercent()
        {
            return mc.ReadSingle(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               CharExpPercentOffset));
        }


        private static int[] CharCurrentExpOffset = { Player_Base, 0x38, 0x10 };
        public static int getCharCurrentExp()
        {
            return mc.ReadInteger(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               CharCurrentExpOffset));
        }

        private static int[] CharPosXOffset = { 0x7F54D8 };
        public static Single getCharPosX()
        {
            return mc.ReadSingle(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               CharPosXOffset));
        }

        private static int[] CharPosYOffset = { 0x7F54DC };
        public static Single getCharPosY()
        {
            return mc.ReadSingle(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               CharPosYOffset));
        }

        private static int[] CharPosZOffset = { 0x7F54E0 };
        public static Single getCharPosZ()
        {
            return mc.ReadSingle(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               CharPosZOffset));
        }
        #endregion


        #region InfosAboutTarget
        private static int targetBase =  0x007BA9E4;
        private static int[] TargetNameOffset = { targetBase, 0xc, 0x10, 0x0 };
        public static String getTargetName()
        {
            return mc.ReadString(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               TargetNameOffset),40);
        }

        private static int[] TargetCurrentHPOffset = { targetBase, 0x10, 0x10 };
        public static Single getTargetCurrentHP()
        {
            return mc.ReadSingle(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               TargetCurrentHPOffset));
        }
        private static int[] TargetMaxHPOffset = { targetBase, 0x50 };
        public static Single getTargetMaxHP()
        {
            return mc.ReadSingle(
               getFinalPointer(mc.getBaseAdress().ToInt32(),
               TargetMaxHPOffset));
        }
    
        private static int[] TargetLevelOffset = { targetBase, 0x18, 0x10, 0x0 }    ;
        public static String getTargetLevel()
        {
          
            return mc.ReadString(
                getFinalPointer(mc.getBaseAdress().ToInt32(),
                TargetLevelOffset),3);

        }

        private static int[] TargetTypeOffset = { targetBase, 0x54 };
        public static int getTargetType()
        {
            return mc.ReadInteger(
                getFinalPointer(mc.getBaseAdress().ToInt32(), TargetTypeOffset)
                );
        }
        #endregion
    }
}
