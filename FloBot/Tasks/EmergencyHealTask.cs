﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using System.Windows.Forms;

namespace FloBot.Tasks
{
    class EmergencyHealTask : ITask
    {
        public bool doTask(MemoryRW mc)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            if (checkForLowHealth(main_form,mc))
                mc.sendKeystroke(Keys.Oemplus);
            
            return true;
        }

        private bool checkForLowHealth(mainForm main_form, MemoryRW mc)
        {
            return AddressUtil.getMaxCharHP() / 100 * 15 > AddressUtil.getCurrentCharHP();
        }
    }
}