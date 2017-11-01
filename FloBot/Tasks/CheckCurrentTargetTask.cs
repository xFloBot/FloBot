using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FloBot.Model;
using System.Threading;

namespace FloBot.Tasks
{
    class CheckCurrentTargetTask : ITask
    {
        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            if (player.inCombat)
                return true;

            //Check if autoloot is checked then if the target name is not "NoTarget" 
            if (main_form.cbAutoLoot.Checked && !player.Target.targetName.Contains("NoTarget")) 

                player.MobToLootCount++;

            while (!player.Target.targetName.Contains("NoTarget") && player.Target.targetName.Length > 0)
            {
                mc.sendKeystroke(Keys.Escape);
                Thread.Sleep(100);
            }
            player.PlayerEngaged = false;
            return false;
        }
    }
}
