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
    class EmergencyMPTask : ITask
    {
        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {

            if (checkForLowMP(main_form, player))
                mc.sendKeystroke(Keys.OemMinus);
            Thread.Sleep(100);
            return true;
        }

        private bool checkForLowMP(mainForm main_form, Player player)
        {
            return player.PlayerMaxMP / 100 * main_form.tbEmMP.Value > player.PlayerCurrentMP;
        }
    }
}
