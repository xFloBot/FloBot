using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using System.Windows.Forms;
using FloBot.Model;

namespace FloBot.Tasks
{
    class EmergencyHealTask : ITask
    {
        public bool doTask(MemoryRW mc)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            if (checkForLowHealth(main_form,mc))
                mc.sendKeystroke(Keys.Oemplus);
            
            return true;
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            throw new NotImplementedException();
        }

        private bool checkForLowHealth(mainForm main_form, MemoryRW mc)
        {
            return AddressUtil.getCharMaxHP() / 100 * main_form.tbEmHP.Value > AddressUtil.getCharCurrentHP();
        }
    }
}
