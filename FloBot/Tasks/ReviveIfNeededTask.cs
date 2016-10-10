using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Model;

namespace FloBot.Tasks
{
    class ReviveIfNeededTask : ITask
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
            if (AddressUtil.getCharCurrentHP() == 0)
            {
                mc.sendLeftClick(mc.getPixelsByPercent(50, 50));
               // GetRestTask.setRestFalse();
                main_form.lblDeathDate.Text = DateTime.Now.ToString("HH:mm:ss");
                return true;
            }
            return false;
           
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            throw new NotImplementedException();
        }
    }
}
