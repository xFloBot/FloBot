using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using System.Windows.Forms;

namespace FloBot.Tasks
{
    class EmergencyMPTask : ITask
    {
        public bool doTask(MemoryRW mc)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            if (checkForLowMP(main_form,mc))
                mc.sendKeystroke(Keys.OemMinus);
            
            return true;
        }

        private bool checkForLowMP(mainForm main_form, MemoryRW mc)
        {
            return AddressUtil.getCharMaxMP() / 100 * main_form.tbEmMP.Value > AddressUtil.getCharCurrentMP();
        }
    }
}
