using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using System.Windows.Forms;
using FloBot.Model;
using System.Threading;

namespace FloBot.Tasks
{
    class EmergencyHPTask : ITask
    {
        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            Thread.Sleep(500);
            if (checkForLowHP(main_form, player))
                mc.sendKeystroke(Keys.Oemplus);
            Thread.Sleep(100);
            return true;
        }

        private bool checkForLowHP(mainForm main_form, Player player)
        {
            return player.PlayerMaxHP/ 100 * main_form.tbEmHP.Value > player.PlayerCurrentHP;
        }
    }
}
