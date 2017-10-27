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
            Console.WriteLine(player.Target.isTargetFriendly());



            if (player.inCombat && !player.Target.isTargetFriendly())
                return true;

            if (player.MobToLootCount > 0)
                return false;

            DateTime mobSearchBreak = DateTime.Now;
            while (
                    (DateTime.Now - mobSearchBreak).TotalSeconds < 5
                    && !player.Target.isValidTarget(main_form)
                    || player.Target.isTargetFriendly() && (DateTime.Now - mobSearchBreak).TotalSeconds < 5
                )
            {
                mc.sendKeystroke(Keys.Tab);
                Thread.Sleep(600);
            }

            while (!player.Target.isValidTarget(main_form) && player.Target.targetCurrentHP > 0)
            {
                mc.sendKeystroke(Keys.Escape);
                Thread.Sleep(50);
            }
            return false;

        }
    }
}
