using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Model;
using System.Threading;

namespace FloBot.Tasks
{
    class ReviveIfNeededTask : ITask
    {
        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            
            while(player.PlayerCurrentHP <= 0 && player.PlayerName.Length >= 3)
            {
                player.Resting = false;
                mc.sendLeftClick(mc.getPixelsByPercent(50, 50));
                Thread.Sleep(100);
            }
            Thread.Sleep(2000);


            return true;
        }
    }
}
