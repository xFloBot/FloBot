using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using FloBot.Model;

namespace FloBot.Tasks
{
    class FocusTargetTask : ITask
    {
        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            DateTime mobSearchBreak = DateTime.Now;
            while(
                    !player.inCombat
                    && (DateTime.Now - mobSearchBreak).TotalSeconds < 5
                    && player.MobToLootCount == 0
                )
            {
                mc.sendKeystroke(Keys.Tab);
                Thread.Sleep(50);
            }

            return true;

        }
    }
}
