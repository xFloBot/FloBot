using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;

namespace FloBot.Tasks
{
    class ReviveIfNeededTask : ITask
    {
        public bool doTask(MemoryRW mc)
        {
            if(AddressUtil.getCurrentCharHP() == 0)
            {
                mc.sendLeftClick(mc.getPixelsByPercent(50,50));
                return true;
            }
            return false;
        }

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            throw new NotImplementedException();
        }
    }
}
