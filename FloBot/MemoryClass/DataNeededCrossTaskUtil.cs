using System;
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
    }
}
