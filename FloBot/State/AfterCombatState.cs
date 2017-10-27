using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Model;
using FloBot.Tasks;
using System.Threading;

namespace FloBot.State
{
    class AfterCombatState : IState
    {
        public IState doTasks(mainForm main_form, MemoryRW mc, Player player)
        {
           

            if (player.inCombat && main_form.cbAutoBattle.Checked)
                return new CombatState();

            Thread.Sleep(100);
            return new IdleState();
        }
    }
}
