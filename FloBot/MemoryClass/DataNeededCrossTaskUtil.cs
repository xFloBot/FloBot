using FloBot.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloBot.MemoryClass
{
    static class DataNeededCrossTaskUtil
    {
        private static int _MobToLootCount = 0;
        private static bool _Resting = false;
        private static ArrayList _buffArray = new ArrayList();
        private static ArrayList _attArray = new ArrayList();
        private static bool _buffed = false;


        private static Single lastX = 0;
        private static Single lastY = 0;
        private static Single lastZ = 0;

        public static bool hasMoved()
        {
            bool moved = AddressUtil.getCharPosX() != LastX
            || AddressUtil.getCharPosY() != LastY
            || AddressUtil.getCharPosZ() != LastZ;

            LastX = AddressUtil.getCharPosX();
            LastY = AddressUtil.getCharPosY();
            LastZ = AddressUtil.getCharPosZ();

            return moved;
        }

        public static int MobToLootCount
        {
            get
            {
                return _MobToLootCount;
            }

            set
            {
                _MobToLootCount = value;
            }
        }

        public static bool Resting
        {
            get
            {
                return _Resting;
            }

            set
            {
                _Resting = value;
            }
        }

        public static ArrayList BuffArray
        {
            get
            {
                return _buffArray;
            }

        }

        public static ArrayList AttArray
        {
            get
            {
                return _attArray;
            }
        }

        public static bool Buffed
        {
            get
            {
                return _buffed;
            }

            set
            {
                _buffed = value;
            }
        }

        public static float LastX
        {
            get
            {
                return lastX;
            }

            set
            {
                lastX = value;
            }
        }

        public static float LastY
        {
            get
            {
                return lastY;
            }

            set
            {
                lastY = value;
            }
        }

        public static float LastZ
        {
            get
            {
                return lastZ;
            }

            set
            {
                lastZ = value;
            }
        }

        public static int addElement(ArrayList al,Skill skill)
        {
            return al.Add(skill);
        }

        public static void removeElement(ArrayList al,Skill skill)
        {
  
            Skill skillToRemove = null;
            foreach(Skill skill2 in al)
            {
                if (skill2.Equals(skill))
                    skillToRemove=skill2;
            }
            if(skillToRemove != null)
                al.Remove(skillToRemove);
  
        }

    }
}
