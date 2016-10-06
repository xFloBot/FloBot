using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace FloBot.Tasks
{
    class FocusTargetTask : ITask
    {
        public bool doTask(MemoryRW mc)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            if (AddressUtil.getTargetName().Contains("NoTarget")&&CheckCurrentTarget.mobsToLoot == 0)
            {
                //Check for target with Max HP
                while (AddressUtil.getTargetCurrentHP() != AddressUtil.getTargetMaxHP()||!checkIfInRange(main_form)&&AddressUtil.getCurrentCharHP() >0)
                {
                    mc.sendKeystroke(Keys.Tab);
                    Thread.Sleep(500);
                }
            }

            return true;
           
        }

        private bool checkIfInRange(mainForm main_form)
        {
            int range;
            int ownLevel = Int32.Parse(main_form.lblCharLvL.Text);
            int monsterLevel;
            //TryParse Target level(It's stored as String in the address dunno why)
            if (!Int32.TryParse(AddressUtil.getTargetLevel(), out monsterLevel))
                return false;
            //Try parse range
            if (!Int32.TryParse(main_form.tbLvLRange.Text, out range)) return false;
            //check if monster level is bigger than ownLevel+ range || smaller than ownLevel-range
            if (monsterLevel > (ownLevel + range)
                || monsterLevel < ownLevel - range)
                return false;

            return true;
        }
    }
}
