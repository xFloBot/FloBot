using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using System.Windows.Forms;
using System.Threading;

namespace FloBot.Tasks
{
    class GetRestTask : ITask
    {
        private static bool resting = false;
        public bool doTask(MemoryRW mc)
        {
            throw new NotImplementedException();
        }
        public static void setRestFalse()
        {
            resting = false;
        }
        private static int currentHP = 0;
        public bool doTask(mainForm main_form, MemoryRW mc)
        {

            if (checkForEmergency(mc))
                return false;

            return needResting(main_form, mc);
        }

        private bool needResting(mainForm main_form,MemoryRW mc)
        {
            //Check if you'r dead
            if (AddressUtil.getCurrentCharHP() == 0 || AddressUtil.getTargetCurrentHP() > 0)
            {
                resting = false;
                return true;
            }
                
            //Check if your Current HP is below 30% and if you'r not resting allready
            //Sit down if this is the case
            else if (
               ((AddressUtil.getCharMaxHP() / 100 * main_form.tbRestHP.Value) > AddressUtil.getCurrentCharHP() || AddressUtil.getCharMaxMP() /100*main_form.tbRestMP.Value >AddressUtil.getCharCurrentMP())
                && !resting)
            {
                int counter = 0;
                while (counter++<20 && AddressUtil.getTargetCurrentHP() == 0)
                    Thread.Sleep(100);
                mc.sendKeystroke(Keys.Z);
                currentHP = AddressUtil.getCurrentCharHP();
                      resting = true;
                return true;
            }

            //Check Current HP and stand up when full
            if (resting)
                if ((AddressUtil.getCharMaxHP()) != AddressUtil.getCurrentCharHP() )
                    return true;
                
                else
                {
                    currentHP = 0;
                    mc.sendKeystroke(Keys.Z);
                }
                    

            resting = false;
            return false;
        }
    

        private bool checkForEmergency(MemoryRW mc)
        {
            if (inCombat()||AddressUtil.getCurrentCharHP() < currentHP)
            {
                if (resting)
                {
                    currentHP = 0;
                    mc.sendKeystroke(Keys.Z);
                    resting = false;
                }
                return true;
            }
            return false;
        }
        
        private bool inCombat()
        {
            return AddressUtil.getTargetCurrentHP() != 0; 
        }
    }
}
