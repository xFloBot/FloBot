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
           if(AddressUtil.getTargetCurrentHP() == 0)
            {
                //Check for target with Max HP
                while(AddressUtil.getTargetCurrentHP() != AddressUtil.getTargetMaxHP())
                {
                    mc.sendKeystroke(Keys.Tab);
                    Thread.Sleep(100);
                }
            }

            return true;
        }

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            throw new NotImplementedException();
        }
    }
}
