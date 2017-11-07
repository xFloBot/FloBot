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
            if (player.PlayerCurrentHP > 0 || !player.allowedToRevive(main_form))
                return false;
            Thread.Sleep(1000);
            while(player.PlayerCurrentHP <= 0 && player.PlayerName.Length >= 3)
            {
                
                mc.sendLeftClick(mc.getPixelsByPercent(50, 50),mc.getPixelsByPercent(50,50));
                Thread.Sleep(100);
            }
            player.Resting = false;
            player.MobToLootCount = 0;
            player.Buffed = false;
            main_form.lblDeathDate.Text = DateTime.Now.ToString("HH:mm:ss");
            Thread.Sleep(1000);


            return true;
        }
    }
}
