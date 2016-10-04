using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using System.Windows.Forms;

namespace FloBot.Tasks
{
    class GetRestTask : ITask
    {
        private static bool resting = false;
        public bool doTask(MemoryRW mc)
        {
            if (checkForEmergency(mc))
                return false;

            return needResting(mc);

        }

        private bool needResting(MemoryRW mc)
        {
            //Check if you'r dead
            if (AddressUtil.getCurrentCharHP() == 0)
                return false;
            //Check if your Current HP is below 30% and if you'r not resting allready
            //Sit down if this is the case
            else if ((getMaxCharHP(mc) / 100 * 30) > getCurrentCharHP(mc) && !resting)
            {
                mc.sendKeystroke(Keys.Z);
                resting = true;
                return true;
            }
            //Check Current HP and stand up when over 80%
            if (resting)
                if ((getMaxCharHP(mc) / 100 * 80) > getCurrentCharHP(mc))
                    return true;
                else
                    mc.sendKeystroke(Keys.Z);

            resting = false;
            return false;
        }

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            throw new NotImplementedException();
        }
        private bool checkForEmergency(MemoryRW mc)
        {
            if (inCombat())
            {
                if (resting)
                {
                    mc.sendKeystroke(Keys.Z);
                    resting = false;
                }
                return true;
            }
            return false;
        }
        private int getCurrentCharHP(MemoryRW mc)
        {
            IntPtr zeiger = IntPtr.Add(mc.getBaseAdress(), 0x00BE7A70);
            
            int zeigerGerade = mc.ReadInteger(zeiger.ToInt32(), 4) + 0x2c8;

            return mc.ReadInteger(zeigerGerade,4);
        }

        private int getMaxCharHP(MemoryRW mc)
        {
            IntPtr zeiger = IntPtr.Add(mc.getBaseAdress(), 0x00BE7A70);

            int zeigerMax = mc.ReadInteger(zeiger.ToInt32(), 4) + 0x2c4;

            return mc.ReadInteger(zeigerMax,4);
        }
        
        private bool inCombat()
        {
            return AddressUtil.getTargetCurrentHP() != 0; 
        }
    }
}
