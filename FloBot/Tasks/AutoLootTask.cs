using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using System.Windows.Forms;
using System.Threading;
using FloBot.Model;

namespace FloBot.Tasks
{
    class AutoLootTask : ITask
    {
        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            while(!player.inCombat && player.MobToLootCount>0)
            {
                int counter = 0;
                while (counter++ < 10 && !player.inCombat) Thread.Sleep(100);
                mc.sendKeystroke(Keys.X);
                
                while (player.Pos.moved() && !player.inCombat) Thread.Sleep(100);

                if (player.inCombat)
                    return true;

                player.MobToLootCount--;
                Thread.Sleep(2000);
            }
            
            return true;
        }
    }
}
