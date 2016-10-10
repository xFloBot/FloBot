using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Model;

namespace FloBot.Tasks
{
    class UpdateTargetInfo : ITask
    {
        public bool doTask(mainForm main_form, Player player)
        {
            player.Target.updateTargetInfo(main_form);
            return true;
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            throw new NotImplementedException();
        }
    }
}
