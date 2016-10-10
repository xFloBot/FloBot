using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Model;

namespace FloBot.Tasks
{
    class UpdateCharInfoTask : ITask
    {
        public bool doTask(mainForm main_form, Player player)
        {
            player.updateCharInfo(main_form);
            return true;
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            throw new NotImplementedException();
        }
    }
}
